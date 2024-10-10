page 50013 "ITS Bill To Address List"
{
    Caption = 'Indirizzi di fatturazione';
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = "ITS Bill-To Address";
    CardPageId = "ITS Bill-To Address Card"; //Duplo clique abre esta card
    Editable = false;

    layout
    {
        area(Content)
        {
            repeater(GroupName)  //o repeater possibilista a lista
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