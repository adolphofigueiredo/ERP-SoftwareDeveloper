page 50107 "Playlist Subpage"
{
    PageType = ListPart;                                             //Set the page type to ListPart, which is used for displaying
                                                                     //a part of a page with a list of records.
    SourceTable = "Playlist Line";                                   //Define the source table for this page.
    AutoSplitKey = true;                                             //Automatically split the key of the page for faster processing.
    DelayedInsert = true;                                            //Enable delayed insert, meaning the page won’t be saved
                                                                     //to the database until explicitly requested.
    layout
    {
        area(content)                                                //Defining the main content area of the page layout.
        {
            repeater(Group)                                          //Defining a repeater to display multiple lines in a group format.
            {
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
                field("Advertising Revenue"; Rec."Advertising Revenue")   //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
            }
        }
    }

    trigger OnNewRecord(BelowxRec: Boolean)                          //Defining a trigger for when a new record is created.
    var
        PlayLine: Record "Playlist Line";                            //Declaring a variable to hold a "Playlist Line" record.
    begin
        Rec."Line No." := 10000;                                     //Set the "Line No." field of the new record to 10000.
        PlayLine.SetRange("Playlist No.", Rec."Playlist No.");       //Set a filter on the "Playlist Line" record to match the "Playlist No." field of the current record (Rec).
        if PlayLine.FindLast() then                                  //If a "Playlist Line" record is found.
            Rec."Line No." += PlayLine."Line No.";                   //Add the "Line No." value from the last found record to the current "Line No.".
    end;
}
