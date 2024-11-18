table 50105 "Publication Line"
{

    fields
    {
        field(1; "Publication No."; Code[20])
        {
            Caption = 'Publication No.';

        }
        field(2; "Line No."; Integer)
        {
            Caption = 'Line No.';
        }
        field(3; Type; Enum "Publication Line Type")
        {
            Caption = 'Type';
        }
        field(4; "No."; Code[20])
        {
            Caption = 'No.';
            TableRelation =
            if (type = const("Resource")) Resource else
            Item;
            trigger OnValidate()
            var
                ItemRec: Record Item;
                ResourceRec: Record Resource;
            begin
                if (Type = Type::Resource) and (ResourceRec.Get("No.")) then
                    Description := ResourceRec.Name
                else
                    if (ItemRec.Get("No.")) then
                        Description := ItemRec.Description;
            end;
        }
        field(5; Description; Text[100])
        {
            Caption = 'Description';


        }
    }

    keys
    {
        key(Key1; "Publication No.", "Line No.")
        {
            Clustered = true;
        }
    }
}