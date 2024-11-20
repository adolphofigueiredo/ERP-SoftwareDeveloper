codeunit 50104 "Radio Show Management"
{
    procedure DeleteAssociatedPlaylistLines(PlaylistNo: Code[20])
    var
        PlaylistLineRec: Record "Playlist Line";
    begin
        //Configuring the filter to exclude all rows associated with the Playlist Header.
        PlaylistLineRec.SetRange("Playlist No.", PlaylistNo);
        if PlaylistLineRec.FindSet() then begin
            repeat
                PlaylistLineRec.Delete();
            until PlaylistLineRec.Next() = 0;
        end;
    end;

    procedure Posting(PlaylistHeader: Record "Playlist Header")
    var
        PlaylistLineRec: Record "Playlist Line";
        RadioShowRec: Record "Radio Show";
        RadioShowEntryRec: Record "Radio Show Entry";
        TotalMusicTime: Duration;
        TotalAdTime: Duration;
        HasResource: Boolean;
    begin
        // Retrieve the associated Radio Show record.
        if not RadioShowRec.Get(PlaylistHeader."Radio Show No.") then
            Error('Il programma radio associato alla playlist non è stato trovato.');

        // Initialize validation variables.
        TotalMusicTime := 0;
        TotalAdTime := 0;
        HasResource := false;

        // Loop through the Playlist Line records to calculate totals and check for resources.
        PlaylistLineRec.SetRange("Playlist No.", PlaylistHeader."No.");
        if PlaylistLineRec.FindSet() then
            repeat
                case PlaylistLineRec.Type of
                    PlaylistLineRec.Type::Item:
                        if PlaylistLineRec."Data Format" <> PlaylistLineRec."Data Format"::Advertisement then
                            TotalMusicTime += PlaylistLineRec.Duration
                        else
                            TotalAdTime += PlaylistLineRec.Duration;

                    PlaylistLineRec.Type::Resource:
                        HasResource := true;
                end;
            until PlaylistLineRec.Next() = 0;

        // Validate Music Min. Time requirement.
        if TotalMusicTime < RadioShowRec."Music Min. Time" then
            Error(
                'La durata totale della musica (%1) è inferiore al minimo richiesto (%2).',
                Format(TotalMusicTime), Format(RadioShowRec."Music Min. Time")
            );

        // Validate Ads Min. Time requirement.
        if TotalAdTime < RadioShowRec."Ads Min. Time" then
            Error(
                'La durata totale delle pubblicità (%1) è inferiore al minimo richiesto (%2).',
                Format(TotalAdTime), Format(RadioShowRec."Ads Min. Time")
            );

        // Check for at least one Resource type in the Playlist Line records.
        if not HasResource then
            Error('Deve esserci almeno una riga di tipo Resource nella Playlist Line.');

        // Create records in the Radio Show Entry table for each Playlist Line.
        PlaylistLineRec.SetRange("Playlist No.", PlaylistHeader."No.");
        if PlaylistLineRec.FindSet() then
            repeat
                RadioShowEntryRec.Init();
                RadioShowEntryRec."Radio Show No." := PlaylistHeader."Radio Show No."; // Use the header's Radio Show No.
                RadioShowEntryRec.Type := PlaylistLineRec.Type;                        // Use the type from the Playlist Line.
                RadioShowEntryRec."No." := PlaylistLineRec."No.";                      // Map the No. field from Playlist Line.
                RadioShowEntryRec.Description := PlaylistLineRec.Description;          // Copy the description.
                RadioShowEntryRec."Data Format" := PlaylistLineRec."Data Format";      // Use the Data Format from Playlist Line.
                RadioShowEntryRec.Duration := PlaylistLineRec.Duration;                // Copy the duration.
                RadioShowEntryRec."Start Time" := PlaylistLineRec."Start Time";        // Use the Start Time.
                RadioShowEntryRec."End Time" := PlaylistLineRec."End Time";            // Use the End Time.
                RadioShowEntryRec."Broadcast Date" := PlaylistHeader."Broadcast Date"; // Map the Broadcast Date from Header.
                RadioShowEntryRec.Insert();
            until PlaylistLineRec.Next() = 0;

        // Delete all Playlist Lines associated with the Playlist Header.
        DeleteAssociatedPlaylistLines(PlaylistHeader."No.");

        // Delete the Playlist Header.
        PlaylistHeader.Delete();
    end;

    procedure CreateInvoice()
    var
        SalesHeaderRec: Record "Sales Header";
        SalesLineRec: Record "Sales Line";
        RadioShowEntryRec: Record "Radio Show Entry";
        RadioShowSetupRec: Record "Sales & Receivables Setup";
    begin
        // Retrieve all Radio Show Entries where Type = Item, Data Format = Advertisement, and Invoiced = No.
        RadioShowEntryRec.SetRange("Type", RadioShowEntryRec.Type::Item);
        RadioShowEntryRec.SetRange("Data Format", RadioShowEntryRec."Data Format"::Advertisement);
        RadioShowEntryRec.SetRange("Invoiced", false); // Only entries where Invoiced = No
        if RadioShowEntryRec.FindSet() then
            repeat
                // Retrieve the setup record for Ads Customer No.
                if not RadioShowSetupRec.Get() then
                    Error('Configurazione radio show non trovata.');

                // Create the Sales Header record for the invoice.
                SalesHeaderRec.Init();
                SalesHeaderRec."Document Type" := SalesHeaderRec."Document Type"::Invoice;
                SalesHeaderRec."Sell-to Customer No." := RadioShowSetupRec."Ads Customer No."; // Use Ads Customer No.
                SalesHeaderRec.Insert();

                // Create the Sales Line record for each Radio Show Entry.
                SalesLineRec.Init();
                SalesLineRec."Type" := SalesLineRec."Type"::Item;
                SalesLineRec."No." := RadioShowEntryRec."No."; // Use No. from Radio Show Entry
                SalesLineRec.Quantity := 1;
                SalesLineRec."Unit Price" := RadioShowEntryRec."Advertising Revenue"; // Use Advertising Revenue
                SalesLineRec."Radio Show Entry No." := RadioShowEntryRec."Entry No."; // Link with Entry No.
                SalesLineRec."Document Type" := SalesHeaderRec."Document Type";
                SalesLineRec."Document No." := SalesHeaderRec."No."; // Link to the Sales Header
                SalesLineRec.Insert();

                // Mark the Radio Show Entry as invoiced.
                RadioShowEntryRec."Invoiced" := true;
                RadioShowEntryRec.Modify();
            until RadioShowEntryRec.Next() = 0;
    end;

    [EventSubscriber(ObjectType::Codeunit, Codeunit::"Sales-Post", 'OnAfterPostSalesLine', '', false, false)]
    local procedure OnAfterPostSalesLineHandler(SalesHeader: Record "Sales Header"; SalesLine: Record "Sales Line")
    var
        RadioShowEntryRec: Record "Radio Show Entry";
    begin
        // Check if the Sales Line has a "Radio Show Entry No."
        if SalesLine."Radio Show Entry No." = 0 then
            exit;

        // Find the corresponding Radio Show Entry record.
        if RadioShowEntryRec.Get(SalesLine."Radio Show Entry No.") then begin
            // Update the "Invoiced" field to Yes.
            RadioShowEntryRec."Invoiced" := true;
            RadioShowEntryRec.Modify();
        end;
    end;
}