tableextension 50130 TE50130 extends "Sales & Receivables Setup"
{
    fields
    {
        field(50100; "Ads. Customet No."; Code[20])
        {
            Caption = 'Ads. Customer No.';
            TableRelation = Customer;
        }
    }

}