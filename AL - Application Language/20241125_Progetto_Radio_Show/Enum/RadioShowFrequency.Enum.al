enum 50100 "Radio Show Frequency"
{
    Extensible = true;                           //Allows new values to be added to this enum in extensions

    value(0; " ")                                //Defining a value with this ID.
    {
        Caption = ' ';                           //It's used to change the name when it is translated.
    }
    value(1; "Hourly")                           //Defining a value with this ID.
    {
        Caption = 'Hourly';                      //It's used to change the name when it is translated.
    }
    value(2; "Daily")                            //Defining a value with this ID.
    {
        Caption = 'Daily';                       //It's used to change the name when it is translated.
    }
    value(3; "Weekly")                           //Defining a value with this ID.
    {
        Caption = 'Weekly';                      //It's used to change the name when it is translated.
    }
    value(4; "Monthly")                          //Defining a value with this ID.
    {
        Caption = 'Monthly';                     //It's used to change the name when it is translated.
    }
}