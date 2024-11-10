table 50100 "Sales Price Lines"                                      //Use command ttable to open a snippet
{
    DataClassification = ToBeClassified;
    Caption = 'Sales Price Lines';                                   //It's used to change the name when it is translated.
                                                                     //'' These symbols are used to say that's a string inside.
                                                                     //Business central cannot handle a field null, so it inserts 0.
    fields
    {
        field(1; "Entry No."; Integer)
        {
            Caption = 'Entry No.';                                   //It's used to change the name when it is translated.
            AutoIncrement = true;                                    //Sets whether the field value should be automatically incremented.
            Editable = false;                                        //Sets a value that indicates whether a field, page, or control can be edited through the UI.
        }

        field(2; "Customer No."; Code[20])
        {
            Caption = 'Customer No.';                                //It's used to change the name when it is translated.
            TableRelation = Customer;                                //Sets up a lookup into another table.
        }

        field(3; "Item No."; Code[20])
        {
            Caption = 'Item No.';                                    //It's used to change the name when it is translated.
            TableRelation = Item;                                    //Sets up a lookup into another table.
        }

        field(4; "Unit Price"; Decimal)
        {
            Caption = 'Price';                                       //It's used to change the name when it is translated.
        }

        field(5; "Min. Qty"; Integer)
        {
            Caption = 'Min. Qty';                                    //It's used to change the name when it is translated.
        }

        field(6; "Enabled"; Boolean)
        {
            Caption = 'Enabled';                                     //It's used to change the name when it is translated.
        }
        field(7; "Starting Date"; Date)
        {
            Caption = 'Starting Date';                               //It's used to change the name when it is translated.
        }
        field(8; "Date Duration"; DateFormula)
        {
            Caption = 'Date Duration';                               //It's used to change the name when it is translated.

            trigger OnValidate()
            begin
                TestField("Starting Date");
                "Ending Date" := CalcDate("Date Duration", "Starting Date");
            end;
        }
        field(9; "Ending Date"; Date)
        {
            Caption = 'Ending Date';                                 //It's used to change the name when it is translated.

            trigger OnValidate()
            begin
                Clear("Date Duration");
            end;
        }
        field(10; "Creation User Id"; Text[50])
        {
            Caption = 'Creation User Id';                            //It's used to change the name when it is translated.
            Editable = false;                                        //Sets a value that indicates whether a field, page, or control can be edited through the UI.
        }
    }

    keys
    {
        key(Key1; "Entry No.")                                       //Defining a Primary key.
        {
            Clustered = true;                                        //A clustered index determines the physical order in which records
                                                                     //are stored in the table. Using a clustered key can improve the
                                                                     //time it takes to retrieve records.
        }
    }

    fieldgroups
    {
        // Add changes to field groups here
    }

    var
        myInt: Integer;

    trigger OnInsert()                                               //It runs automatically after the user chooses to insert a new record in a page from the Web client.
    begin
        Rec.Enabled := true;                                         //Condition created to activate the enabled field when a price is entered.
                                                                     //It is not necessary to write "Rec."
        "Creation User Id" := UserId;
    end;

    trigger OnModify()
    begin

    end;

    trigger OnDelete()
    begin

    end;

    trigger OnRename()
    begin

    end;

}