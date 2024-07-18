table 50114 Module
{
    fields
    {
        field(1; Code; Code[20])
        {
        }
        field(2; "Course No."; Code[20])
        {
            TableRelation = Course;
        }
        field(3; "Vendor No."; Code[20])
        {
            //FieldClass = FlowField;
            //CalcFormula = Vendor where("Prof. Fiscal Code" = field(Code));
        }
        field(4; "Vendor Name"; Text[100])
        {
            Editable = false;
            FieldClass = FlowField;
            CalcFormula = lookup("Vendor"."Prof. Full Name" where("Prof. Fiscal Code" = field("Vendor No.")));
        }
        field(5; Name; Text[100])
        {
        }
        field(6; "Hour Number"; Integer)
        {
        }
        field(7; "Hourly Cost"; Enum "Hourly Cost Range")
        {
        }
        field(8; "Total Cost"; Decimal)
        {
        }
    }

    keys
    {
        key(Key1; Code, "Course No.", "Vendor No.")
        {
            Clustered = true;
        }

    }
}