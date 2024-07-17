page 50005 "ITS Book List"    //usar o comando tpage -> list para criar uma pagina pre formatada
{
    Caption = 'Book List';
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = "ITS Book";
    CardPageId = "ITS Book Card"; //Associar a a card para abrir desta lista
    Editable = false;     //Agora esta lista nao pode ser mais editada diretamente, mais
                          //ou menos como se fosse um excel.
    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("No."; Rec."No.")
                {
                    ApplicationArea = All; //é utilizado para fazer com que o campo serja visivel.

                }
                field(Date; Rec.Date)
                {
                    ApplicationArea = All; //é utilizado para fazer com que o campo serja visivel.
                    Visible = false;
                }
                field(Title; Rec.Title)
                {
                    ApplicationArea = All; //é utilizado para fazer com que o campo serja visivel.

                }
                field(Description; Rec.Description)
                {
                    ApplicationArea = All; //é utilizado para fazer com que o campo serja visivel.
                    Visible = false;
                }
                field("Author Name"; Rec."Author Name")
                {
                    ApplicationArea = All; //é utilizado para fazer com que o campo serja visivel.

                }


                field(Quantity; Rec.Quantity)
                {
                    ApplicationArea = All; //é utilizado para fazer com que o campo serja visivel.

                }
            }
        }
        area(Factboxes)
        {

            systempart(Notes; Notes)
            {
                ApplicationArea = All;
                Visible = true;
            }

            systempart(Links; Links)
            {
                ApplicationArea = All;
                Visible = false;
            }
        }
    }
}