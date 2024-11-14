tableextension 50103 "Sales Setup" extends "Sales & Receivables Setup"
{
    fields
    {
        field(50100; "Ads Customer No."; Code[20])                   //Adding a new field with this Id, name anda data type.
        {
            Caption = 'Ads Customer No.';                            //It's used to change the name when it is translated.
            TableRelation = "Customer";                              //Sets up a lookup into another table ("Customer").
        }
    }
}