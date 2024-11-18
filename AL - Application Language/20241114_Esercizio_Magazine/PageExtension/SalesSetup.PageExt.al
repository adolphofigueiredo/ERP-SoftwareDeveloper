pageextension 50130 PE50130 extends "Sales & Receivables Setup"
{
    layout
    {
        addlast(General)
        {
            field("Ads. Customet No."; Rec."Ads. Customet No.")
            {
                ApplicationArea = All;
            }
        }
    }
}