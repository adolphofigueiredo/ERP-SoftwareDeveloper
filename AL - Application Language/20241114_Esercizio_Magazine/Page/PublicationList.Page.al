page 50104 "Publication List"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = "Publication Header";
    CardPageId = "Publication Card";

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
                field("Magazine No."; Rec."Magazine No.")
                {
                    ApplicationArea = All;
                }
                field(Number; Rec.Number)
                {
                    ApplicationArea = All;
                }
                field(Description; Rec.Description)
                {
                    ApplicationArea = All;
                }
                field("Publication Date"; Rec."Publication Date")
                {
                    ApplicationArea = All;
                }
            }
        }
        area(Factboxes)
        {

        }
    }
}