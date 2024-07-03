page 50105 "ITS Bill To Address List"
{
    Caption = 'Indirizzi di fatturazione';
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = "ITS Bill-To Address";
    CardPageId = "ITS Bill-To Address Card"; //duplo clique abre esta card
    Editable = false;

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
                field("Customer No."; Rec."Customer No.")
                {
                    ApplicationArea = All;

                }
                field(Name; Rec.Name)
                {
                    ApplicationArea = All;

                }
            }
        }
    }
}