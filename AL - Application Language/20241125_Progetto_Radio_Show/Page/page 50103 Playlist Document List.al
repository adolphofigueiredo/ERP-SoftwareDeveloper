page 50103 "Playlist Document List"
{
    PageType = List;
    SourceTable = "Playlist Header";
    ApplicationArea = All;
    CardPageId = "Playlist Document";
    UsageCategory = Documents;

    layout
    {
        area(content)
        {
            repeater(Group)
            {
                field("No."; Rec."No.") { ApplicationArea = All; }
                field("Radio Show No."; Rec."Radio Show No.") { ApplicationArea = All; }
                field("Radio Show Type"; Rec."Radio Show Type") { ApplicationArea = All; }
                field(Description; Rec.Description) { ApplicationArea = All; }
                field("Broadcast Date"; Rec."Broadcast Date") { ApplicationArea = All; }
                field(Duration; Rec.Duration) { ApplicationArea = All; }
                field("Start Time"; Rec."Start Time") { ApplicationArea = All; }
                field("End Time"; Rec."End Time") { ApplicationArea = All; }
                field("Royalty Cost"; Rec."Royalty Cost") { ApplicationArea = All; }
                field("Advertising Revenue"; Rec."Advertising Revenue") { ApplicationArea = All; }
            }
        }
    }
}
