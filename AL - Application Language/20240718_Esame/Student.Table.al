table 50028 Student
{
    fields
    {
        field(1; "Fiscal Code"; Code[20])
        {
        }
        field(2; "Full Name"; Text[100])
        {
        }
        field(3; "Birth Date"; Date)
        {
        }
        field(4; "Enrolled Course"; Code[20])
        {
            TableRelation = Course;
        }
    }

    keys
    {
        key(Key1; "Fiscal Code")
        {
            Clustered = true;
        }
    }
}