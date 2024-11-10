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
                    // filtro tutti i prezzi per il cliente
                    SalesPriceLines.SetRange("Customer No.", Rec."No.");
                    // imposto i filtri sulla pagina dei prezzi e la apro
                    SalesPriceLinesList.SetTableView(SalesPriceLines);
                    SalesPriceLinesList.Run();
                end;
            }
        }
    }
}