tableextension 50103 "Sales Setup" extends "Sales & Receivables Setup"
{
    fields
    {
        field(50100; "Ads Customer No."; Code[20])
        {
            Caption = 'Ads Customer No.';
            TableRelation = "Customer";
        }
    }
}