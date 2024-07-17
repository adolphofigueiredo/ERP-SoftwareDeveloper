pageextension 50112 "ITS Customer List Extension" extends "Customer List"
{
    layout
    {
        addafter(Name)
        {
            field("Bill-to Address Exists"; Rec."Bill-to Address Exists")
            {
                ApplicationArea = All;
            }
        }
    }
}