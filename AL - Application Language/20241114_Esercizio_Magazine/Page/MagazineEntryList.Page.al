page 50103 "Magazine Entry List"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = History;
    SourceTable = "Magazine Entry";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("Entry No."; Rec."Entry No.")
                {
                    ApplicationArea = All;

                }
                field("Magazine No."; Rec."Magazine No.")
                {
                    ApplicationArea = All;
                }
                field(Type; Rec.Type)
                {
                    ApplicationArea = All;
                }
                field("No."; Rec."No.")
                {
                    ApplicationArea = All;
                }
                field("Publication Date"; Rec."Publication Date")
                {
                    ApplicationArea = All;
                }
                field(Description; Rec.Description)
                {
                    ApplicationArea = All;
                }
                field("Magazine Number"; Rec."Magazine Number")
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