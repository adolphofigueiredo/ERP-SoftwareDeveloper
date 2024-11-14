page 50102 "Radio Show Type"
{
    PageType = List;                                                 //Set the page type to List which display multiple records in a list format.
    SourceTable = "Radio Show Type";                                 //Define the source table for this page.
    ApplicationArea = All;                                           //Make this page available in all application areas.
    UsageCategory = Administration;                                  //Categorize this page under Administration for the UI

    layout
    {
        area(content)
        {
            repeater(Group)                                          //Define a repeater to display multiple lines.
            {
                field(Code; Rec.Code)                                //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
                field(Description; Rec.Description)                  //Adding this field, linked to the Rec."field".
                {
                    ApplicationArea = All;                           //Make this field available in all application areas.
                }
            }
        }
    }
}
