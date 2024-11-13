page 50107 "Playlist Subpage"
{
    PageType = ListPart;
    SourceTable = "Playlist Line";
    AutoSplitKey = true;
    DelayedInsert = true;

    layout
    {
        area(Content)
        {
            repeater(Group)
            {
                field(Type; Rec.Type) { ApplicationArea = All; }
                field("No."; Rec."No.")
                {
                    ApplicationArea = All;
                }
                field("Data Format"; Rec."Data Format") { ApplicationArea = All; }
                field(Description; Rec.Description) { ApplicationArea = All; }
                field(Duration; Rec.Duration) { ApplicationArea = All; }
                field("Start Time"; Rec."Start Time") { ApplicationArea = All; }
                field("End Time"; Rec."End Time") { ApplicationArea = All; }
                field("Royalty Cost"; Rec."Royalty Cost") { ApplicationArea = All; }
                field("Advertising Revenue"; Rec."Advertising Revenue") { ApplicationArea = All; }
            }
        }
    }

    trigger OnNewRecord(BelowxRec: Boolean)
    var
        PlayLine: Record "Playlist Line";
    begin
        Rec."Line No." := 10000;
        PlayLine.SetRange("Playlist No.", Rec."Playlist No.");
        if PlayLine.FindLast() then
            Rec."Line No." += PlayLine."Line No.";
    end;
}
