pageextension 50100 TE50100 extends "Customer List"
{
    actions
    {
        addfirst(processing)
        {
            action("Open Sales Price")
            {
                Caption = 'Open Sales Price';
                Image = Open;

                trigger OnAction()
                var
                    SalesPriceLinesList: Page "Sales Price Lines";
                    SalesPriceLines: Record "Sales Price Lines";
                begin
                    SalesPriceLines.SetRange("Customer No.", Rec."No.");  //Filter all the prices for this customer.
                    SalesPriceLinesList.SetTableView(SalesPriceLines);    //Set the filters on the price page and open it.
                    SalesPriceLinesList.Run();                            //Opening
                end;
            }
        }
    }
}