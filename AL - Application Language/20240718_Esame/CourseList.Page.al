page 50022 "Course List"
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
                RunObject = page "Student List";
                RunPageLink = "Enrolled Course" = field("No.");
            }
            action("Show Module List")
            {
                Caption = 'Mostra Lista Moduli';
                ApplicationArea = All;
                RunObject = page "Module List";
                RunPageLink = "Course No." = field("No.");
            }
        }
    }
}