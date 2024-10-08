page 50029 "Student List"
{
    Caption = 'Lista Studenti';
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = Student;
    Editable = true;
    DelayedInsert = true;

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("Fiscal Code"; Rec."Fiscal Code")
                {
                    ApplicationArea = All;
                }
                field("Full Name"; Rec."Full Name")
                {
                    ApplicationArea = All;
                }
                field("Birth Date"; Rec."Birth Date")
                {
                    ApplicationArea = All;
                }
                field("Enrolled Course"; Rec."Enrolled Course")
                {
                    ApplicationArea = All;
                }
            }
        }
    }
}