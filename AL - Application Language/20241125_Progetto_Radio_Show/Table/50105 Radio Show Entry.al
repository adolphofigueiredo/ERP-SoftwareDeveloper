table 50105 "Radio Show Entry"
{
    fields
    {
        field(1; "Entry No."; Integer)
        {
            Caption = 'Entry No.';
            AutoIncrement = true;
            Editable = false;
        }
        field(10; "Radio Show No."; Code[20])
        {
            Caption = 'Radio Show No.';
        }
        field(20; Type; Enum "Playlist Line Type")
        {
            Caption = 'Type';
        }
        field(30; "No."; Code[20])
        {
            Caption = 'No.';
        }
        field(40; "Data Format"; Enum "Data Format Type")
        {
            Caption = 'Data Format';
        }
        field(50; Description; Text[50])
        {
            Caption = 'Description';
        }
        field(60; "Broadcast Date"; Date)
        {
            Caption = 'Broadcast Date';
        }
        field(70; "Start Time"; Time)
        {
            Caption = 'Start Time';
        }
        field(80; Duration; Duration)
        {
            Caption = 'Duration';
        }
        field(90; "End Time"; Time)
        {
            Caption = 'End Time';
        }
        field(100; "Royalty Cost"; Decimal)
        {
            Caption = 'Royalty Cost';
        }
        field(110; "Advertising Revenue"; Decimal)
        {
            Caption = 'Advertising Revenue';
        }
        field(120; "Invoiced"; Boolean)
        {
            Caption = 'Invoiced';
        }
    }
    keys
    {
        key(PK; "Entry No.")
        {
            Clustered = true;
        }
    }
}