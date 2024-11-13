page 50104 "Playlist Document"
{
    PageType = Document;
    SourceTable = "Playlist Header";
    ApplicationArea = All;
    UsageCategory = Documents;
    layout
    {
        area(content)
        {
            group(Group)
            {
                field("No."; Rec."No.") { ApplicationArea = All; }
                field("Radio Show No."; Rec."Radio Show No.")
                {
                    ApplicationArea = All;
                }
                field("Radio Show Type"; Rec."Radio Show Type")
                {
                    ApplicationArea = All;
                }
                field(Description; Rec.Description) { ApplicationArea = All; }
                field("Broadcast Date"; Rec."Broadcast Date") { ApplicationArea = All; }
                field(Duration; Rec.Duration) { ApplicationArea = All; }
                field("Start Time"; Rec."Start Time") { ApplicationArea = All; }
                field("End Time"; Rec."End Time") { ApplicationArea = All; }
                field("Royalty Cost"; Rec."Royalty Cost")
                {
                    ApplicationArea = All;
                }
                field("Advertising Revenue"; Rec."Advertising Revenue")
                {
                    ApplicationArea = All;
                }
            }
            part(lines; "Playlist Subpage")
            {
                SubPageLink = "Playlist No." = FIELD("No.");
            }
        }
    }
}
