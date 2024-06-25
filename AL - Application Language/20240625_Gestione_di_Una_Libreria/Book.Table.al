table 50101 Book
{
    fields
    {
        field(1; "No."; Code[20])
        {

        }
        field(2; Title; Text[50])
        {

        }
        field(3; Description; Text[250])
        {

        }
        field(4; "Author No."; Code[20])
        {
            TableRelation = Author;
        }
        field(5; "Author Name"; Text[50])
        {
            FieldClass = FlowField;
            CalcFormula = lookup(Author.Name where("No." = field("Author No.")));
        }
        field(6; Date; Date)
        {

        }
        field(7; Price; Decimal)
        {

        }
        field(8; Discount; Decimal)
        {

        }
        field(9; Quantity; Integer)
        {

        }
    }

    keys
    {
        key(Key1; "No.")
        {
            Clustered = true;
        }
        key(Key2; Title)
        {

        }
        key(Key3; "Author No.", Date)
        {

        }
    }
}