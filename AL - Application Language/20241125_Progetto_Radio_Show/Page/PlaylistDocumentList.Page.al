page 50103 "Playlist Document List"
{
    PageType = List;                                                 //Set the page type to List which display multiple records in a list format.
    SourceTable = "Playlist Header";                                 //Define the source table for this page.
    ApplicationArea = All;                                           //Make this page available in all application areas.
    CardPageId = "Playlist Document";                                //Link to a detailed Card Page with this ID for record details.
    UsageCategory = Documents;                                       //Categorize this page as Documents, under the Reports and Analysis category in the UI.

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
                field("Radio Show No."; Rec."Radio Show No.")        //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field("Radio Show Type"; Rec."Radio Show Type")      //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field(Description; Rec.Description)                  //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field("Broadcast Date"; Rec."Broadcast Date")        //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field(Duration; Rec.Duration)                        //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field("Start Time"; Rec."Start Time")                //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field("End Time"; Rec."End Time")                    //Adding this field, linked to the Rec."field".
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
