table 50021 Course
{
    fields
    {
        field(1; "No."; Code[20])
        {

        }
        field(2; Name; Text[50])
        {

        }
        field(3; Type; Enum "Course Type")
        {

        }
        field(4; "Students Number"; Integer)
        {
            Editable = false;
            FieldClass = FlowField;
            CalcFormula = count(Student where("Enrolled Course" = field("No.")));
        }
        field(6; "Total Cost"; Decimal)
        {
            Editable = false;
            FieldClass = FlowField;
            CalcFormula = sum(Module."Total Cost" where("Course No." = field("No.")));
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