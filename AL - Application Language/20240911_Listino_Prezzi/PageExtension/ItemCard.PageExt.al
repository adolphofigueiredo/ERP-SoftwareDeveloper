pageextension 50103 TE50103 extends "Item Card"
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
                    SalesPriceLines.SetRange("Item No.", Rec."No.");      //Filter all the prices for this item.
                    SalesPriceLinesList.SetTableView(SalesPriceLines);    //Set the filters on the price page and open it.
                    SalesPriceLinesList.Run();                            //Opening
                end;
            }
        }
    }
}