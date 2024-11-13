page 50101 "Radio Show Card"
{
    PageType = Card;
    SourceTable = "Radio Show";

    layout
    {
        area(content)
        {
            group(General)
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
            }
            group(Requirements)
            {
                field("Music Min. Time"; Rec."Music Min. Time")
                {
                    ApplicationArea = All;
                }
                field("Ads Min. Time"; Rec."Ads Min. Time")
                {
                    ApplicationArea = All;
                }
            }
            group(Statistics)
            {
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
