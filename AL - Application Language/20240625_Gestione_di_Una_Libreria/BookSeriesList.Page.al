page 50007 "ITS Book Series List"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = "ITS Book Series";
    Editable = true;
    Caption = 'Book Series List';

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
                field(Category; Rec.Category)
                {
                    ApplicationArea = All;

                }
                field("Book Number"; Rec."Book Number")
                {
                    ApplicationArea = All;

                }
            }
        }

    }

}