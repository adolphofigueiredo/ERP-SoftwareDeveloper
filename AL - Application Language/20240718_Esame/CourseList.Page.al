page 50118 "Course List"
{
    Caption = 'Lista Corsi';
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = Course;
    Editable = true;

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("No."; Rec."No.")
                {
                    ApplicationArea = All;
                }
                field(Name; Rec.Name)
                {
                    ApplicationArea = All;
                }
                field(Type; Rec.Type)
                {
                    ApplicationArea = All;
                }
                field("Students Number"; Rec."Students Number")
                {
                    ApplicationArea = All;
                }
                field("Total Cost"; Rec."Total Cost")
                {
                    ApplicationArea = All;
                }
            }

        }

    }
    actions
    {
        area(Navigation)
        {
            action("Show Student List ")
            {
                Caption = 'Mostra Lista Studenti';
                ApplicationArea = All;

                trigger OnAction()
                begin

                end;
            }

            // 10) Nella pagina "Course List" inserire un pulsante nel menu "Navigation",
            // con caption "Mostra Lista Studenti", che apra la lista degli studenti collegati al corso.


            action("Show Module List")
            {
                Caption = 'Mostra Lista Moduli';
                ApplicationArea = All;

                trigger OnAction()
                begin

                end;
            }
            // 13) Nella pagina "Course List" inserire un pulsante nel menu "Navigation",
            // con caption "Mostra Lista Moduli", che apra la lista dei moduli collegati al corso.
        }
    }

}