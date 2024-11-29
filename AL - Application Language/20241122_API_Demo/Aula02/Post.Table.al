table 50100 Post
{
    DataClassification = ToBeClassified;

    fields
    {
        field(1; Id; Integer)
        {
            DataClassification = ToBeClassified;
            AutoIncrement = true;
        }
        field(2; "External Id"; Integer)
        { }
        field(3; "User Id"; Integer)
        { }
        field(4; "Title"; Text[250])
        { }
        field(5; "Body"; Text[1024])
        { }
    }

    keys
    {
        key(Key1; Id)
        {
            Clustered = true;
        }
    }
}