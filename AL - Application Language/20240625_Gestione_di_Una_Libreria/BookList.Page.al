page 50103 "Book List"    //usar o comando tpage -> list para criar uma pagina pre formatada
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = Book;
    CardPageId = "Book Card";

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

    actions
    {
        area(Processing)
        {
            action(ActionName)
            {
                ApplicationArea = All;

                trigger OnAction()
                begin

                end;

            }
        }
    }
}