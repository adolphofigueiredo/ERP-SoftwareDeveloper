page 50106 "Publication Subpage"
{
    PageType = ListPart;
    AutoSplitKey = true;
    DelayedInsert = true;
    SourceTable = "Publication Line";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("Type"; Rec."Type")
                {
                    ApplicationArea = All;
                }
                field("No."; Rec."No.")
                {
                    ApplicationArea = All;
                }
                field(Description; Rec.Description)
                {
                    ApplicationArea = All;
                }
            }
        }
    }
}