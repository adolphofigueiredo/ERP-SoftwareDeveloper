tableextension 50102 "Sales Invoice Line" extends "Sales Invoice Line"
{
    fields
    {
        field(50100; "Radio Show Entry No."; Integer)                //Adding a new field with this Id, name anda data type.
        {
            Caption = 'Radio Show Entry No.';                        //It's used to change the name when it is translated.
        }
    }
}