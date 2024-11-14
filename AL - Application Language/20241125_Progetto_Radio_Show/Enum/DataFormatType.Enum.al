enum 50102 "Data Format Type"
{
    Extensible = true;                           //Allows new values to be added to this enum in extensions

    value(0; " ")                                //Defining a value with this ID.
    {
        Caption = ' ';                           //It's used to change the name when it is translated.
    }
    value(1; "Vinyl")                            //Defining a value with this ID.
    {
        Caption = 'Vinyl';                       //It's used to change the name when it is translated.
    }
    value(2; "CD")                               //Defining a value with this ID.
    {
        Caption = 'CD';                          //It's used to change the name when it is translated.
    }
    value(3; "MP3")                              //Defining a value with this ID.
    {
        Caption = 'MP3';                         //It's used to change the name when it is translated.
    }
    value(4; "Advertisement")                    //Defining a value with this ID.
    {
        Caption = 'Advertisement';               //It's used to change the name when it is translated.
    }
}