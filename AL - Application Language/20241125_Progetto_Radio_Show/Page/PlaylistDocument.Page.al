page 50104 "Playlist Document"
{
    PageType = Document;                                             //Set the page type to Document, used for detailed documents or reports.
    SourceTable = "Playlist Header";                                 //Define the source table for this page.
    ApplicationArea = All;                                           //Make this page available in all application areas.
    UsageCategory = Documents;                                       //Categorize this page as Documents, under the Reports and Analysis category in the UI.

    layout
    {
        area(content)                                                //Defining the main content area of the page layout.
        {
            group(Group)                                             //Defining a group with this name to group related fields together.
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
            part(lines; "Playlist Subpage")                          //Define a part (a subpage) to display additional related details.
            {
                SubPageLink = "Playlist No." = FIELD("No.");         //Link the subpage to the current record by matching the "Playlist No."
                                                                     //field with the "No." field of the current record
            }
        }
    }

    actions
    {
        area(processing)                                                 //Define a new action area for processing actions.
        {
            action(Register)                                             //Define the Register action.
            {
                Caption = 'Registra';                                    //Set the action's display name in Italian.
                ApplicationArea = All;                                   //Make this action available in all application areas.
                Image = PostDocument;                                    //Use a suitable icon for the action.

                trigger OnAction()
                var
                    RadioShowMgmt: Codeunit "Radio Show Management";     //Declare a variable for the Radio Show Management codeunit.
                begin
                    RadioShowMgmt.Posting(Rec);                          //Call the Posting method, passing the current record (Playlist Header).
                end;
            }
        }
    }
}