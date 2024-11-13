page 50100 "Radio Show List"
{
    PageType = List;
    SourceTable = "Radio Show";
    ApplicationArea = All;
    UsageCategory = Lists;
    CardPageId = "Radio Show Card";
    Editable = false;

    layout
    {
        area(content)
        {
            repeater(Group)
            {
                field("No."; Rec."No.")
                {
                    ApplicationArea = All;
                }
                field("Name"; Rec."Name")
                {
                    ApplicationArea = All;
                }
                field("Radio Show Type"; Rec."Type")
                {
                    ApplicationArea = All;
                }
                field(Frequency; Rec.Frequency)
                {
                    ApplicationArea = All;
                }
                field("Run Time"; Rec."Run Time")
                {
                    ApplicationArea = All;
                }
                field("Music Min. Time"; Rec."Music Min. Time")
                {
                    ApplicationArea = All;
                }
                field("Ads Min. Time"; Rec."Ads Min. Time")
                {
                    ApplicationArea = All;
                }
                field("Royalty Cost"; Rec."Royalty Cost")
                {
                    ApplicationArea = All;
                }
                field("Advertising Revenue"; Rec."Advertising Revenue")
                {
                    ApplicationArea = All;
                }
            }

        }
    }
}
