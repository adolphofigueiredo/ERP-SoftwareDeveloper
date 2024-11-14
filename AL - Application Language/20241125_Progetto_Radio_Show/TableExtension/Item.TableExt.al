tableextension 50100 Item extends Item
{
    fields
    {
        field(50100; Duration; Duration)                             //Adding a new field with this Id, name anda data type.
        {
            Caption = 'Duration';                                    //It's used to change the name when it is translated.
        }
        field(50101; "Data Format"; Enum "Data Format Type")         //Adding a new field with this Id, name anda data type.
        {
            Caption = 'Data Format';                                 //It's used to change the name when it is translated.
        }
        field(50102; "Radio Show Type"; Code[10])                    //Adding a new field with this Id, name anda data type.
        {
            Caption = 'Radio Show Type';                             //It's used to change the name when it is translated.
            TableRelation = "Radio Show Type";                       //Sets up a lookup into another table ("Radio Show Type").
        }
    }
}