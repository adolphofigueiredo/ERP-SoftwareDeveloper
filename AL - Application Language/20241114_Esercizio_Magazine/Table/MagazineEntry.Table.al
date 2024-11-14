table 50127 "Magazine Entry"
{

    fields
    {
        field(1; "Entry No."; Integer)
        {
            Caption = 'Entry No.';
            AutoIncrement = true;
            Editable = false;
        }
        field(2; "Magazine No."; Code[20])
        {
            Caption = 'Magazine No.';
            TableRelation = Magazine;
        }
        field(3; Type; Enum "Publication Line Type")
        {
            Caption = 'Type';
        }
        field(4; "No."; Code[20])
        {
            Caption = 'No.';
        }
        field(5; "Publication Date"; Date)
        {
            Caption = 'Publication Date';
        }
        field(6; "Description"; Text[100])
        {
            Caption = 'Description';
        }
        field(7; "Magazine Number"; Integer)
        {
            Caption = 'Magazine Number';
        }
    }

    keys
    {
        key(Key1; "Entry No.")
        {
            Clustered = true;
        }
    }
}