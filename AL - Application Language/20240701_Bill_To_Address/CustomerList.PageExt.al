pageextension 50102 "ITS Customer List Extension" extends "Customer List"
{
    layout
    {
        addafter(Name)
        {
            field("Bill-to Address Exist"; Rec."Bill-to Address Exist")
            {
                ApplicationArea = All;
            }
        }
    }
}