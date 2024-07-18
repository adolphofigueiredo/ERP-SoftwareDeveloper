page 50119 "Course List"
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
            action("Show List")
            {
                Caption = 'Mostra Lista Moduli';
                ApplicationArea = All;

                trigger OnAction()
                begin

                end;
            }
        }
    }

}