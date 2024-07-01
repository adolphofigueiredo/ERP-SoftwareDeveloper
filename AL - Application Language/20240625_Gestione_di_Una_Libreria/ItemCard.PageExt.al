//https://learn.microsoft.com/en-us/dynamics365/business-central/dev-itpro/developer/devenv-page-ext-object
//é uma pagina criada para fazer uma extensao em uma
//pagina padrao da microsoft ou em uma pagina que se
//for modificada pode criar problemas . Nao faz sentido
//criar uma extensao em uma pagina que eu posso modificar.

//https://learn.microsoft.com/en-us/dynamics365/business-central/dev-itpro/developer/devenv-actions-overview
//https://learn.microsoft.com/en-us/dynamics365/business-central/dev-itpro/developer/devenv-promoted-actions
//
//

pageextension 50100 ITSItemCardPageExt extends "Item Card"
{
    layout
    {
        addbefore(Item)
        {
            group(Book)
            {
                field("Book No."; Rec."Book No.")
                {
                    ApplicationArea = All;
                }

                field("Book Title"; Rec."Book Title")
                {
                    ApplicationArea = All;
                }
            }
        }
    }
    actions
    {
        addfirst(reporting)
        {
            group(Books)
            {
                action(Livro)
                {
                    ApplicationArea = All;
                    Caption = 'Livro';
                    RunObject = page "ITS Book Card";
                    RunPageLink = "No." = field("Book No.");
                    Image = PrintReport;
                    ToolTip = 'Click for additional information.';
                }
            }
        }
    }

    var
        myInt: Integer;
}