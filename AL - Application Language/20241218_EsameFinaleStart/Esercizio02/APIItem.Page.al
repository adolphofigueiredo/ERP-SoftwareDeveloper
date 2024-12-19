page 50108 "API Item"
{

    //http://bcserver:7048/BC/api/its/wms/v1.0/companies(86d89be1-369f-ef11-8a6d-6045bde9ba24)/items?tenant=default

    PageType = API;
    Caption = 'apiPageName';
    APIPublisher = 'ITS';
    APIGroup = 'wms';
    APIVersion = 'v1.0';
    EntityName = 'item';
    EntitySetName = 'items';
    SourceTable = Item;
    DelayedInsert = true;

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("no"; Rec."No.")
                {

                }
                field(description; Rec.Description)
                {

                }
                field("unit_of_measure"; Rec."Base Unit of Measure")
                {

                }
                field(type; Rec.Type)
                {

                }
                field("unit_price"; Rec."Unit Price")
                {

                }
                field("unit_cost"; Rec."Unit Cost")
                {

                }
                field("last_date_modified"; Rec."Last Date Modified")
                {

                }
            }
        }
    }
}
