tableextension 50100 Item extends Item
{
    fields
    {
        field(50100; Duration; Duration)
        {
            Caption = 'Duration';
        }
        field(50101; "Data Format"; Enum "Data Format Type")
        {
            Caption = 'Data Format';
        }
        field(50102; "Radio Show Type"; Code[10])
        {
            Caption = 'Radio Show Type';
            TableRelation = "Radio Show Type";
        }
    }
}