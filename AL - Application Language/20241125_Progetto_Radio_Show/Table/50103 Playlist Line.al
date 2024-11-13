table 50103 "Playlist Line"
{
    fields
    {
        field(1; "Playlist No."; Code[20])
        {
            Caption = 'Playlist No.';
            TableRelation = "Playlist Header"."No.";
        }
        field(2; "Line No."; Integer)
        {
            Caption = 'Line No.';
        }
        field(10; Type; Enum "Playlist Line Type")
        {
            Caption = 'Type';
        }
        field(20; "No."; Code[20])
        {
            Caption = 'No.';
            TableRelation =
            if (type = const("Item")) Item
            else
            if (type = const("Resource")) Resource;
        }
        field(30; "Data Format"; Enum "Data Format Type")
        {
            Caption = 'Data Format';
        }
        field(50; Description; Text[50])
        {
            Caption = 'Description';
        }
        field(60; Duration; Duration)
        {
            Caption = 'Duration';
            Editable = false;
        }
        field(70; "Start Time"; Time)
        {
            Caption = 'Start Time';

            trigger OnValidate()
            begin
                if Duration <> 0 then
                    "End Time" := "Start Time" + Duration;
            end;
        }
        field(80; "End Time"; Time)
        {
            Caption = 'End Time';
            Editable = false;
        }
        field(90; "Royalty Cost"; Decimal)
        {
            Caption = 'Royalty Cost';
        }
        field(100; "Advertising Revenue"; Decimal)
        {
            Caption = 'Advertising Revenue';
        }
    }

    keys
    {
        key(PK; "Playlist No.", "Line No.")
        {
            Clustered = true;
        }
    }

}