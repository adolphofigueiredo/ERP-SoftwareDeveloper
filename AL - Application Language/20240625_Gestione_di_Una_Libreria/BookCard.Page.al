page 50104 "Book Card"     //usar o comando tpage -> card para criar uma pagina pre formatada
{
    PageType = Card;
    ApplicationArea = All;
    UsageCategory = Administration;
    SourceTable = Book;

    layout
    {
        area(Content)
        {
            group(General)
            {

                Caption = 'General';// o caption é usado para mudar o nome de verdade, se usa isso para traduzir os nomes de tabelas campos e etc

                field("No."; Rec."No.")
                {
                    ApplicationArea = All;
                }

                field(Title; Rec.Title)
                {
                    ApplicationArea = All;
                }

                field(Description; Rec.Description)
                {
                    ApplicationArea = All;
                }

                field(Date; Rec.Date)
                {
                    ApplicationArea = All;
                }

                field("Author No."; Rec."Author No.")
                {
                    ApplicationArea = All;
                }

                field("Author Name"; Rec."Author Name")
                {
                    ApplicationArea = All;
                }
            }
            group(Sale)
            {
                Caption = 'Sale'; // o caption é usado para mudar o nome de verdade, se usa isso para traduzir os nomes de tabelas campos e etc

                field(Quantity; Rec.Quantity)
                {
                    ApplicationArea = All;
                    Editable = false;
                }

                field(Price; Rec.Price)
                {
                    ApplicationArea = All;
                }
                field(Discount; Rec.Discount)
                {
                    ApplicationArea = All;
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
                Visible = true;
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

    var
        myInt: Integer;
}