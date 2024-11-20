table 50102 "Playlist Header"
{
    fields
    {
        field(1; "No."; Code[20])                                    //Creating a field in the table.
        {
            Caption = 'No.';                                         //It's used to change the name when it is translated.
        }
        field(10; "Radio Show No."; code[20])                        //Creating a field in the table.
        {
            Caption = 'Radio Show No.';                              //It's used to change the name when it is translated.
            TableRelation = "Radio Show"."No.";                      //Sets up a lookup into another table ("Radio Show"."No.").
            Trigger OnValidate()
            var
                RadioShowRec: Record "Radio Show";
            begin
                RadioShowRec.Get(Rec."Radio Show No.");
                Rec.Description := RadioShowRec.Name;
                Rec.Duration := RadioShowRec."Run Time";
                Rec."Radio Show Type" := RadioShowRec.Type;
            end;
        }
        field(11; "Radio Show Type"; Code[10])                       //Creating a field in the table.
        {
            Caption = 'Radio Show Type';                             //It's used to change the name when it is translated.
            TableRelation = "Radio Show Type"."Code";                //Sets up a lookup into another table ("Radio Show Type"."Code").
        }
        field(20; Description; Text[50])                             //Creating a field in the table.
        {
            Caption = 'Description';                                 //It's used to change the name when it is translated.
        }
        field(30; "Broadcast Date"; Date)                            //Creating a field in the table.
        {
            Caption = 'Broadcast Date';                              //It's used to change the name when it is translated.
        }
        field(40; Duration; Duration)                                //Creating a field in the table.
        {
            Caption = 'Duration';                                    //It's used to change the name when it is translated.
            Editable = false;                                        //Sets a value that indicates whether a field, page, or
                                                                     //control can be edited through the UI.
        }
        field(50; "Start Time"; Time)                                //Creating a field in the table.
        {
            Caption = 'Start Time';                                  //It's used to change the name when it is translated.
            trigger OnValidate()                                     //Check if the Start Time is not equal to 0 (meaning it has been set by the user)
            begin
                if "Start Time" <> 0T then                           //If Start Time is set and not equal to 0.
                    "End Time" := "Start Time" + Duration;           //Calculate the End Time by adding the Duration to the Start Time.
            end;
        }
        field(60; "End Time"; Time)                                  //Creating a field in the table.
        {
            Caption = 'End Time';                                    //It's used to change the name when it is translated.
            Editable = false;                                        //Sets a value that indicates whether a field, page, or
                                                                     //control can be edited through the UI.
        }
        field(70; "Royalty Cost"; Decimal)                           //Creating a field in the table.
        {
            Caption = 'Royalty Cost';                                //It's used to change the name when it is translated.
            Editable = false;
            FieldClass = FlowField;
            CalcFormula = Sum("Playlist Line"."Royalty Cost" WHERE("Type" = CONST(Item), "Playlist No." = FIELD("No.")));
        }
        field(80; "Advertising Revenue"; Decimal)                    //Creating a field in the table.
        {
            Caption = 'Advertising Revenue';                         //It's used to change the name when it is translated.
            Editable = false;
            FieldClass = FlowField;
            CalcFormula = Sum("Playlist Line"."Advertising Revenue" WHERE("Type" = CONST(Item), "Playlist No." = FIELD("No.")));
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
    trigger OnDelete()
    var
        RadioShowMgmt: Codeunit "Radio Show Management";

    begin
        // Calls the Codeunit to delete associated Playlist Lines
        RadioShowMgmt.DeleteAssociatedPlaylistLines("No.");
    end;
}