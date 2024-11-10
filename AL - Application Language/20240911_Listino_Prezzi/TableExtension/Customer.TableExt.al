tableextension 50101 CustomerExt extends Customer
{
    trigger OnAfterDelete()
    var
        SalesPriceLines: Record "Sales Price Lines";
    begin
        SalesPriceLines.SetRange("Customer No.", Rec."No.");    //Filter all prices for the customer.
        SalesPriceLines.DeleteAll();                            //Delete all the prices found.
    end;
}