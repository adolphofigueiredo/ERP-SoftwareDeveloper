table 50103 "ITS Bill-To Address"
{
    Caption = 'Bill-To Address';

    fields
    {
        field(1; "Entry No."; Integer)
        {
            Caption = 'Entry No.';
            AutoIncrement = true;
        }

        field(2; "Customer No."; Code[20])
        {
            Caption = 'Customer No.';
        }
        field(3; "Name"; Text[100])
        {
            Caption = 'Name';
        }
        field(4; "Address"; Text[250])
        {
            Caption = 'Address';
        }
        field(5; "Country/Region Code"; Code[10])
        {
            Caption = 'Country/Region Code';
            TableRelation = "Country/Region".Code;
        }
        field(6; "City"; Text[30])
        {
            Caption = 'Citta';
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