table 50104 "Radio Show Entry"
{
    fields
    {
        field(1; "Entry No."; Integer)                               //Creating a field in the table.
        {
            Caption = 'Entry No.';                                   //It's used to change the name when it is translated.
            AutoIncrement = true;                                    //Enable AutoIncrement, meaning the system will automatically
                                                                     //generate a unique sequential value for this field when a new record is created
            Editable = false;                                        //Sets a value that indicates whether a field, page, or
                                                                     //control can be edited through the UI.
        }
        field(10; "Radio Show No."; Code[20])                        //Creating a field in the table.
        {
            Caption = 'Radio Show No.';                              //It's used to change the name when it is translated.
        }
        field(20; Type; Enum "Playlist Line Type")                   //Creating a field in the table.
        {
            Caption = 'Type';                                        //It's used to change the name when it is translated.
        }
        field(30; "No."; Code[20])                                   //Creating a field in the table.
        {
            Caption = 'No.';                                         //It's used to change the name when it is translated.
        }
        field(40; "Data Format"; Enum "Data Format Type")            //Creating a field in the table.
        {
            Caption = 'Data Format';                                 //It's used to change the name when it is translated.
        }
        field(50; Description; Text[50])                             //Creating a field in the table.
        {
            Caption = 'Description';                                 //It's used to change the name when it is translated.
        }
        field(60; "Broadcast Date"; Date)                            //Creating a field in the table.
        {
            Caption = 'Broadcast Date';                              //It's used to change the name when it is translated.
        }
        field(70; "Start Time"; Time)                                //Creating a field in the table.
        {
            Caption = 'Start Time';                                  //It's used to change the name when it is translated.
        }
        field(80; Duration; Duration)                                //Creating a field in the table.
        {
            Caption = 'Duration';                                    //It's used to change the name when it is translated.
        }
        field(90; "End Time"; Time)                                  //Creating a field in the table.
        {
            Caption = 'End Time';                                    //It's used to change the name when it is translated.
        }
        field(100; "Royalty Cost"; Decimal)                          //Creating a field in the table.
        {
            Caption = 'Royalty Cost';                                //It's used to change the name when it is translated.
        }
        field(110; "Advertising Revenue"; Decimal)                   //Creating a field in the table.
        {
            Caption = 'Advertising Revenue';                         //It's used to change the name when it is translated.
        }
        field(120; "Invoiced"; Boolean)                              //Creating a field in the table.
        {
            Caption = 'Invoiced';                                    //It's used to change the name when it is translated.
        }
    }
    keys
    {
        key(PK; "Entry No.")                                         //Defining a Primary key.
        {
            Clustered = true;                                        //A clustered index determines the physical order in which records
                                                                     //are stored in the table. Using a clustered key can improve the
                                                                     //time it takes to retrieve records.
        }
    }
}