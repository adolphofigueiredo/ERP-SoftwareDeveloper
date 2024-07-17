//https://learn.microsoft.com/en-us/dynamics365/business-central/dev-itpro/developer/devenv-page-ext-object
//é uma pagina criada para fazer uma extensao em uma
//pagina padrao da microsoft ou em uma pagina que se
//for modificada pode criar problemas . Nao faz sentido
//criar uma extensao em uma pagina que eu posso modificar.

//https://learn.microsoft.com/en-us/dynamics365/business-central/dev-itpro/developer/devenv-actions-overview
//https://learn.microsoft.com/en-us/dynamics365/business-central/dev-itpro/developer/devenv-promoted-actions
//
//

pageextension 50010 "ITS Item Card Extension" extends "Item Card"
{
    layout
    {
        addafter(Item)
        {
            group(Book)
            {
                Caption = 'Libro';
                field("Book Num"; Rec."Book Num")
                {
                    ApplicationArea = All;
                }

                field("Book Tit."; Rec."Book Tit.")
                {
                    ApplicationArea = All;
                }
            }
        }
    }
    actions
    {                   //nao foi adicionado area em actyions pq o botao ja existe
                        // se eu quisesse criar um botao teria colocado area() e continuaria
        addfirst(navigation)    //Navigation em italiano significa Correlato
        {
            group(Books)  //esse grupo adiciona uma subpasta dentro da pasta para agrupar os botos em uma lista
            {
                action(ShowBookCard) //o botao nunca aparecera enquanto ele nao tiver uma acao programada
                {
                    Caption = 'Mostra dettaglio Libro';
                    ApplicationArea = All;
                    Image = TestFile;
                    RunObject = page "ITS Book Card";
                    RunPageLink = "No." = field("Book Num"); //link do valor que deve aparecer
                    Enabled = Rec."Book Num" <> ''; //Para dizer que o botao so pode aparecer se tiver
                                                    //algum valor e se nao tiver nenhum valor
                                                    //ele nao pode aparecer
                    ToolTip = 'Click for additional information.';
                }
            }
        }
    }
    var
        myInt: Integer;
}