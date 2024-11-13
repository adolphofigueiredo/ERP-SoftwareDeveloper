table 50101 "Radio Show Type"
{
    fields
    {
        field(1; Code; Code[10])                                     //Creating a field in the table.
        {
            Caption = 'Code';                                        //It's used to change the name when it is translated.
        }
        field(2; Description; Text[50])                              //Creating a field in the table.
        {
            Caption = 'Description';                                 //It's used to change the name when it is translated.
        }
    }
}