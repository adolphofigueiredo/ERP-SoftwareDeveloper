tableextension 50102 ItemExt extends Item
{
    trigger OnAfterDelete()
    var
        SalesPriceLines: Record "Sales Price Lines";
    begin
        SalesPriceLines.SetRange("Item No.", Rec."No.");   //Filter all prices for the item.
        SalesPriceLines.DeleteAll();                       //Delete all the prices found.
    end;
}