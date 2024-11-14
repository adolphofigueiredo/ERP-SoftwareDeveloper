page 50101 "Radio Show Card"
{
    PageType = Card;                                                 //Set the page type to Card, displaying detailed information for a single record.
    SourceTable = "Radio Show";                                      //Define the source table for this page.

    layout
    {
        area(content)                                                //Defining the main content area of the page layout.
        {
            group(General)                                           //Defining a group with this name to group related fields together.
            {
                field("No."; Rec."No.")                              //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field("Name"; Rec."Name")                            //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field("Radio Show Type"; Rec."Type")                 //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field(Frequency; Rec.Frequency)                      //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field("Run Time"; Rec."Run Time")                    //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
            }
            group(Requirements)                                      //Defining a group with this name to group related fields together.
            {
                field("Music Min. Time"; Rec."Music Min. Time")      //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field("Ads Min. Time"; Rec."Ads Min. Time")          //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
            }
            group(Statistics)                                        //Defining a group with this name to group related fields together.
            {
                field("Royalty Cost"; Rec."Royalty Cost")            //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field("Advertising Revenue"; Rec."Advertising Revenue")   //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
            }
        }
    }
}
