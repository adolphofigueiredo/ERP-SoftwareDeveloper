page 50106 ApiPageName
{

    //http://bcserver:7048/BC/api/companyxy/vendita/v1.0/orders?tenant=default
    //http://bcserver:7048/BC/api/companyxy/vendita/v1.0/companies(86d89be1-369f-ef11-8a6d-6045bde9ba24)/orders?tenant=default    


    PageType = API;
    Caption = 'apiPageName';
    APIPublisher = 'companyxy';
    APIGroup = 'vendita';
    APIVersion = 'v1.0';
    EntityName = 'order';
    EntitySetName = 'orders';
    SourceTable = "Sales Header";
    DelayedInsert = true;
    SourceTableView = where("Document Type" = const(Order));                   //Estou usando um filtro para limitar o que sera enviado.

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field(customer_name; Rec."Sell-to Customer Name") { }
                field(customer_no; Rec."Sell-to Customer No.") { }
                field(order_no; Rec."No.") { }
                field(external_document; Rec."External Document No.") { }
                field(document_date; Rec."Document Date") { }
                field(status; Rec.Status) { }
                field(amount; Rec.Amount) { }
            }
        }
    }
    var
    trigger OnOpenPage()
    var
        myInt: Integer;
    begin

    end;


}