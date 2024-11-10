page 50100 "Sales Price Lines"                                       //Use command tpage to open a snippet.
{
    PageType = List;                                                 //Choosing the page type to create a good user experience.
    UsageCategory = Lists;                                           //The page or report will show up when you use the search functionality.
    ApplicationArea = All;                                           //It is used to make the field visible, means that the control will always appear in the user interface.
    SourceTable = "Sales Price Lines";
    Caption = 'Lista Prezzi ITS';                                    //It's used to change the name when it is translated.
                                                                     //'' These symbols are used to say that's a string inside.
                                                                     //Business central cannot handle a field null, so it inserts 0.

    layout
    {
        area(Content)
        {
            group(GroupName)
            {
                field("Entry No."; Rec."Entry No.")                  //Rec. means record of the sourcetable that was mentioned at the beginning of the code.
                {
                    ApplicationArea = All;                           //It is used to make the field visible, means that the control will always appear in the user interface.

                }
                field("Customer No."; Rec."Customer No.")             //Rec. means record of the sourcetable that was mentioned at the beginning of the code.
                {
                    ApplicationArea = All;                           //It is used to make the field visible, means that the control will always appear in the user interface.

                }
                field("Item No."; Rec."Item No.")                     //Rec. means record of the sourcetable that was mentioned at the beginning of the code.
                {
                    ApplicationArea = All;                           //It is used to make the field visible, means that the control will always appear in the user interface.

                }

                field("Unit Price"; Rec."Unit Price")                 //Rec. means record of the sourcetable that was mentioned at the beginning of the code.
                {
                    ApplicationArea = All;                           //It is used to make the field visible, means that the control will always appear in the user interface.

                }

                field("Min. Qty"; Rec."Min. Qty")                     //Rec. means record of the sourcetable that was mentioned at the beginning of the code.
                {
                    ApplicationArea = All;                           //It is used to make the field visible, means that the control will always appear in the user interface.

                }

                field(Enabled; Rec.Enabled)                           //Rec. means record of the sourcetable that was mentioned at the beginning of the code.
                {
                    ApplicationArea = All;                           //It is used to make the field visible, means that the control will always appear in the user interface.

                }
            }
        }
    }

    actions
    {
        area(Processing)
        {
            action("Create Sales Order")
            {
                Caption = 'Create Sales Order';
                Image = Create;
                ApplicationArea = All;

                // pulsante per creare un ordine di vendita a partire da righe di prezzo
                trigger OnAction()
                var
                    SalesPriceMgmt: Codeunit "Sales Price Management";
                    SalesPriceLines: Record "Sales Price Lines";
                begin
                    // Appunta i records che l'utente ha selezionato nella pagina e 
                    // imposta un filtro sulla tabella per filtrare solo quei record
                    Currpage.SetSelectionFilter(SalesPriceLines);
                    // richiama la funzione per creare un ordine con i record prezzi selezionati dall'utente
                    SalesPriceMgmt.CreateSalesOrderFromSalesPrice(SalesPriceLines);
                end;
            }
        }
    }
}