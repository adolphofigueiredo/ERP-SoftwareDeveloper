table 50100 "Bill-To Address"
{
    Caption = 'Bill-To Address';

    fields
    {
        field(1; MyField; Integer)
        {
            DataClassification = ToBeClassified;

        }

        field(2; MyField; Integer)
        {
            DataClassification = ToBeClassified;

        }

        field(3; MyField; Integer)
        {
            DataClassification = ToBeClassified;

        }

        field(4; MyField; Integer)
        {
            DataClassification = ToBeClassified;

        }

        field(5; MyField; Integer)
        {
            DataClassification = ToBeClassified;

        }

        field(6; MyField; Integer)
        {
            DataClassification = ToBeClassified;

        }
    }

    keys
    {
        key(Key1; MyField)
        {
            Clustered = true;
        }
    }

    fieldgroups
    {
        // Add changes to field groups here
    }

    var
        myInt: Integer;

    trigger OnInsert()
    begin

    end;

    trigger OnModify()
    begin

    end;

    trigger OnDelete()
    begin

    end;

    trigger OnRename()
    begin

    end;

}