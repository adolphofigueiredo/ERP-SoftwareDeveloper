table 50100 "Radio Show"
{
    fields
    {
        field(1; "No."; Code[20])                                    //Creating a field in the table.
        {
            Caption = 'No.';                                         //It's used to change the name when it is translated.
        }
        field(2; "Name"; Text[50])                                   //Creating a field in the table.
        {
            Caption = 'Name';                                        //It's used to change the name when it is translated.
        }
        field(3; "Type"; Code[10])                                   //Creating a field in the table.
        {
            Caption = 'Type';                                        //It's used to change the name when it is translated.
            TableRelation = "Radio Show Type";                       //Sets up a lookup into another table ("Radio Show Type").
        }
        field(4; Frequency; Enum "Radio Show Frequency")             //Creating a field in the table.
        {
            Caption = 'Frequency';                                   //It's used to change the name when it is translated.
        }
        field(5; "Run Time"; Duration)                               //Creating a field in the table.
        {
            Caption = 'Run Time';                                    //It's used to change the name when it is translated.
        }
        field(6; "Music Min. Time"; Duration)                        //Creating a field in the table.
        {
            Caption = 'Music Min. Time';                             //It's used to change the name when it is translated.
        }
        field(7; "Ads Min. Time"; Duration)                          //Creating a field in the table.
        {
            Caption = 'Ads Min. Time';                               //It's used to change the name when it is translated.
        }
        field(10; "Royalty Cost"; Decimal)                           //Creating a field in the table.
        {
            Caption = 'Royalty Cost';                                //It's used to change the name when it is translated.
            FieldClass = FlowField;
            CalcFormula = Sum("Radio Show Entry"."Royalty Cost" WHERE("Type" = CONST(Item), "Radio Show No." = FIELD("No.")));

        }
        field(11; "Advertising Revenue"; Decimal)                    //Creating a field in the table.
        {
            Caption = 'Advertising Revenue';                         //It's used to change the name when it is translated.
            FieldClass = FlowField;
            CalcFormula = Sum("Radio Show Entry"."Advertising Revenue" WHERE("Type" = CONST(Item), "Radio Show No." = FIELD("No.")));
        }
    }
    keys
    {
        key(PK; "No.")                                               //Defining a Primary key.
        {
            Clustered = true;                                        //A clustered index determines the physical order in which records
                                                                     //are stored in the table. Using a clustered key can improve the
                                                                     //time it takes to retrieve records.
        }
    }
}
