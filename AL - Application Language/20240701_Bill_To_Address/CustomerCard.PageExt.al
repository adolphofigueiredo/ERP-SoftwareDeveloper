pageextension 50101 "ITS Customer Card Extension" extends "Customer Card"
{

    layout
    {
        addlast(General)
        {
            field("Bill-to Address Exist"; Rec."Bill-to Address Exist")
            {
                ApplicationArea = All;
            }
        }
    }

    actions
    {
        addfirst(navigation)     //Navigation em italiano significa Correlato
        {
            action(BillToAddressList)
            {
                Image = Navigate;
                ApplicationArea = All;
                Caption = 'Indirizzi di fatturazione';
                RunObject = page "ITS Bill To Address List";
                RunPageLink = "Customer No." = field("No.");
            }
        }
    }
}