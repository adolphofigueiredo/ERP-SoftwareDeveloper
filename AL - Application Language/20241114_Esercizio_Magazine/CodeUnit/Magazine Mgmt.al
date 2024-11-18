codeunit 50100 "Magazine Maganagement"
{
    procedure Posting(PublicationHdr: Record "Publication Header")
    var
        Magazine: Record Magazine;
        PubLine: Record "Publication Line";
        MagEntry: Record "Magazine Entry";
        CountVar: Integer;
        CountArt: Integer;

    begin

        // Verificare che i vincoli di numero articoli e pubblicità siano rispettati

        Magazine.Get(PublicationHdr."Magazine No.");

        PubLine.SetRange("Publication No.", PublicationHdr."No.");
        PubLine.SetRange(Type, PubLine.Type::Article);
        CountArt := PubLine.Count();
        if CountArt < Magazine."Articles No." then
            Error('Numero articoli non sufficiente');

        PubLine.SetRange(Type, PubLine.Type::Ads);
        CountVar := PubLine.Count();
        if CountVar < Magazine."Ads No." then
            Error('Numero pubblicità non sufficienti');

        // Verificare che ci sia almeno una risorsa ogni due articoli (es. se ho 10 articoli devo avere almeno 5 risorse)

        PubLine.SetRange(Type, PubLine.Type::Resource);
        CountVar := PubLine.Count();
        if CountVar * 2 < CountArt then
            Error('Numero risorsi non sufficienti');

        // Deve scrivere la Magazine Entry

        PubLine.Reset();
        PubLine.SetRange("Publication No.", PublicationHdr."No.");
        if PubLine.FindSet() then
            repeat
                //Creazione Magazine entry per ogni publication line
                MagEntry.Init();
                MagEntry."Entry No." := 0;
                MagEntry."Magazine No." := PublicationHdr."Magazine No.";
                MagEntry.Type := PubLine.Type;
                MagEntry."No." := PubLine."No.";
                MagEntry."Publication Date" := PublicationHdr."Publication Date";
                MagEntry.Description := PubLine.Description;
                MagEntry."Magazine Number" := PublicationHdr.Number;
                MagEntry.Insert();
            until PubLine.Next() = 0;

        // Deve creare una fattura di vendita per le pubblicità ad un unico cliente impostato a setup (es. è la loro agenzia pubblicitaria)

        CreateInvoice(PublicationHdr);

        // Elimino la Publication Header e le Publication Line

        PubLine.DeleteAll();
        PublicationHdr.Delete();

    end;

    local procedure CreateInvoice(PubblicationHdr: Record "Publication Header")
    var
        SalesSetup: Record "Sales & Receivables Setup";
        SalesHdr: Record "Sales Header";
        PubLine: Record "Publication Line";
        SalesLine: Record "Sales Line";
        LineNo: Integer;
    begin
        //Creare una fattura di vendita verso l'agenzia pubblicitaria
        //Mettere a setup il codice cliente dell'agenzia

        SalesSetup.Get();

        //Creare la testata della fattura con il codice dell'agenzia

        SalesHdr.Init();
        SalesHdr."Document Type" := SalesHdr."Document Type"::Invoice;
        SalesHdr."No." := '';
        SalesHdr.Validate("Sell-to Customer No.", SalesSetup."Ads. Customet No.");
        SalesHdr.Insert(true);

        //Creare le righe di vendita sulla base delle righe di pubblicazione di tipo ads
        PubLine.SetRange("Publication No.", PubblicationHdr."No.");
        PubLine.SetRange(Type, PubLine.Type::Ads);
        if PubLine.FindSet() then
            repeat
                LineNo += 1;

                //Creare riga di vendita
                SalesLine.Init();
                SalesLine."Document Type" := SalesHdr."Document Type";
                SalesLine."Document No." := SalesHdr."No.";
                SalesLine."Line No." := LineNo;
                SalesLine.Validate(Type, SalesLine.Type::Item);
                SalesLine.Validate("No.", PubLine."No.");
                SalesLine.Validate(Quantity, 1);
                SalesLine.Insert();
            until PubLine.Next() = 0;
    end;
}