page 50106 "Radio Show Entries"
{
    PageType = List;                                                 //Set the page type to List which display multiple records in a list format.
    SourceTable = "Radio Show Entry";                                //Define the source table for this page.
    UsageCategory = History;                                         //Categorize this page under History, under the Reports and Analysis category in the UI.
    ApplicationArea = All;                                           //Make this page available in all application areas.

    layout
    {
        area(content)                                                //Defining the main content area of the page layout.
        {
            repeater(Group)                                          //Defining a repeater to display multiple lines in a group format.
            {
                field("Entry No."; Rec."Entry No.")                  //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field("Radio Show No."; Rec."Radio Show No.")        //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field(Type; Rec.Type)                                //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field("No."; Rec."No.")                              //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field("Data Format"; Rec."Data Format")              //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field(Description; Rec.Description)                  //Adding this field, linked to the Rec."field".
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
                field("Advertising Revenue"; Rec."Advertising Revenue")    //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field("Invoiced"; Rec."Invoiced")                    //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
            }
        }
    }
    actions
    {
        area(processing)                                                 //Define a new action area for processing actions.
        {
            action(CreateInvoice)
            {
                Caption = 'CreateInvoice';
                ApplicationArea = All;
                //Image = ;                                    

                trigger OnAction()
                var
                    RadioShowMgmt: Codeunit "Radio Show Management";     //Declare a variable for the Radio Show Management codeunit.
                begin
                    RadioShowMgmt.CreateInvoice();                          //Call the Posting method, passing the current record (Playlist Header).
                end;
            }
        }
    }
}
