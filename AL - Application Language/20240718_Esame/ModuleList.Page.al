page 50027 "Module List"
{
    Caption = 'Lista Moduli';
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = Module;
    Editable = false;

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field(Code; Rec.Code)
                {
                    ApplicationArea = All;
                }
                field("Course No."; Rec."Course No.")
                {
                    ApplicationArea = All;
                }
                field(Name; Rec.Name)
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
}