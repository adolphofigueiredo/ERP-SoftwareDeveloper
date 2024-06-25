page 50102 "Author List"    //usar o comando tpage -> list para criar uma pagina pre formatada
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = Author;

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

                field(Name; Rec.Name)
                {
                    ApplicationArea = All; //é utilizado para fazer com que o campo serja visivel.
                }

                field("Country Code"; Rec."Country Code")
                {
                    ApplicationArea = All; //é utilizado para fazer com que o campo serja visivel.
                }

                field("Country Name"; Rec."Country Name")
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