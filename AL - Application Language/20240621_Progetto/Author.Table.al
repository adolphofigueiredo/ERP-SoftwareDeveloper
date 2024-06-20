table 50100 Author
{

    fields
    {
        field(1; "No."; Code[20])
        {

        }

        field(2; Name; Text[50])
        {

        }
        field(3; "Country Code"; Code[10])
        {

        }
        field(4; "Country Name"; Code[50])
        {
            TableRelation = "Country/Region".Code;
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