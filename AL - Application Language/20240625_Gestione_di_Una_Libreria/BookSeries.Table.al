table 50006 "ITS Book Series"
{
    Caption = 'Book Series';

    fields
    {
        field(1; "No."; Code[20])
        {
            Caption = 'No.';
        }
        field(2; Category; Enum "ITS Category Book Series")
        {
            Caption = 'Category';
        }
        field(3; "Book Number"; Integer)
        {
            Caption = 'Book Number';
            FieldClass = FlowField;
            CalcFormula = count("ITS Book" where("Book Series No." = field("No.")));
        }
    }
    keys
    {
        key(Key1; "No.")
        {
            Clustered = true;
        }
    }

}