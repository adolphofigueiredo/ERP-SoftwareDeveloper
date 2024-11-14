page 50100 "Radio Show List"
{
    PageType = List;                                                 //Set the page type to List which display multiple records in a list format.
    SourceTable = "Radio Show";                                      //Define the source table for this page.
    ApplicationArea = All;                                           //Make this page available in all application areas.
    UsageCategory = Lists;                                           //Categorize this page under Lists in the UI
    CardPageId = "Radio Show Card";                                  //Link to a detailed Card Page with this ID for record details.
    Editable = false;                                                //Make this page non-editable, so records cannot be modified directly here.

    layout
    {
        area(content)                                                //Defining the main content area of the page layout.
        {
            repeater(Group)                                          //Defining a repeater to display multiple lines in a group format.
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
                field("Music Min. Time"; Rec."Music Min. Time")      //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field("Ads Min. Time"; Rec."Ads Min. Time")          //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
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
