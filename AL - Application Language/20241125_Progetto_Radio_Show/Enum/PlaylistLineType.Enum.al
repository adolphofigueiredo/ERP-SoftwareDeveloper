enum 50101 "Playlist Line Type"
{
    Extensible = true;                           //Allows new values to be added to this enum in extensions

    value(0; " ")                                //Defining a value with this ID.
    {
        Caption = ' ';                           //It's used to change the name when it is translated.
    }
    value(1; "Resource")                         //Defining a value with this ID.
    {
        Caption = 'Resource';                    //It's used to change the name when it is translated.
    }
    value(2; "Item")                             //Defining a value with this ID.
    {
        Caption = 'Item';                        //It's used to change the name when it is translated.
    }
}