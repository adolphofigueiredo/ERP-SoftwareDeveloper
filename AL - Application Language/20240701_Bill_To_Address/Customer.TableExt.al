tableextension 50101 ITSCustomerTableExt extends Customer
{
    fields
    {
        field(50102; "Bill-to Address Exist"; Boolean)
        {
            FieldClass = FlowField;
            CalcFormula = ;
        }
    }

    keys
    {
        // Add changes to keys here
    }

    fieldgroups
    {
        // Add changes to field groups here
    }

    var
        myInt: Integer;
}