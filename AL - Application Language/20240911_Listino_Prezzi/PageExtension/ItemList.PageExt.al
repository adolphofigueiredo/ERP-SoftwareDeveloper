pageextension 50104 TE50104 extends "Item List"
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
                    // filtro tutti i prezzi per l'articolo
                    SalesPriceLines.SetRange("Item No.", Rec."No.");
                    // imposto i filtri sulla pagina dei prezzi e la apro
                    SalesPriceLinesList.SetTableView(SalesPriceLines);
                    SalesPriceLinesList.Run();
                end;
            }
        }
    }
}