table 50100 Book
{
    fields
    {
        field(1; "Code"; Code[20]) { }
        field(2; "ISBN"; Code[20]) { }
        field(3; "Title"; Text[150]) { }
        field(4; "Description"; Text[500]) { }
        field(5; "Author No."; Code[20]) { }
    }

    keys
    {
        key(Key1; Code)
        {
            Clustered = true;
        }
    }
}