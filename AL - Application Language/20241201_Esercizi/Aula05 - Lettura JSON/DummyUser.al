table 50102 "Dummy User"
{

    fields
    {
        field(1; Id; Integer)
        {
            AutoIncrement = true;
        }
        field(2; "External Id"; Integer) { }
        field(3; FirstName; Text[100]) { }
        field(4; LastName; Text[100]) { }
        field(5; Email; Text[100]) { }
        field(6; Phone; Text[100]) { }
        field(7; Age; Integer) { }
    }

    keys
    {
        key(Key1; Id)
        {
            Clustered = true;
        }
    }
}