page 50106 "Radio Show Entries"
{
    PageType = List;
    SourceTable = "Radio Show Entry";
    UsageCategory = History;
    ApplicationArea = All;

    layout
    {
        area(content)
        {
            repeater(Group)
            {
                field("Entry No."; Rec."Entry No.") { ApplicationArea = All; }
                field("Radio Show No."; Rec."Radio Show No.") { ApplicationArea = All; }
                field(Type; Rec.Type) { ApplicationArea = All; }
                field("No."; Rec."No.") { ApplicationArea = All; }
                field("Data Format"; Rec."Data Format") { ApplicationArea = All; }
                field(Description; Rec.Description) { ApplicationArea = All; }
                field(Duration; Rec.Duration) { ApplicationArea = All; }
                field("Start Time"; Rec."Start Time") { ApplicationArea = All; }
                field("End Time"; Rec."End Time") { ApplicationArea = All; }
                field("Royalty Cost"; Rec."Royalty Cost") { ApplicationArea = All; }
                field("Advertising Revenue"; Rec."Advertising Revenue") { ApplicationArea = All; }
                field("Invoiced"; Rec."Invoiced") { ApplicationArea = All; }
            }
        }
    }
}
