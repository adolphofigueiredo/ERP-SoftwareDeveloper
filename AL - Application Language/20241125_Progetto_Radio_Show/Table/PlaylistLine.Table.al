table 50103 "Playlist Line"
{
    fields
    {
        field(1; "Playlist No."; Code[20])                           //Creating a field in the table.
        {
            Caption = 'Playlist No.';                                //It's used to change the name when it is translated.
            TableRelation = "Playlist Header"."No.";                 //Sets up a lookup into another table ("Playlist Header"."No.").
        }
        field(2; "Line No."; Integer)                                //Creating a field in the table.
        {
            Caption = 'Line No.';                                    //It's used to change the name when it is translated.
        }
        field(10; Type; Enum "Playlist Line Type")                   //Creating a field in the table.
        {
            Caption = 'Type';                                        //It's used to change the name when it is translated.
        }
        field(20; "No."; Code[20])                                   //Creating a field in the table.
        {
            Caption = 'No.';                                         //It's used to change the name when it is translated.
            TableRelation =
            if (type = const("Item")) Item                           //If the "type" field is "Item," sets up a lookup into another table ("Item").
            else
            if (type = const("Resource")) Resource;                  //If the "type" field is "Item," sets up a lookup into another table ("Resource").

            trigger OnValidate()
            var
                ResourceRec: Record Resource;
                ItemRec: Record Item;
                PlaylistHeaderRec: Record "Playlist Header";
            begin
                case Type of
                    Type::Resource:
                        begin
                            if ResourceRec.Get("No.") then
                                Description := ResourceRec.Name
                        end;

                    Type::Item:
                        begin
                            if ItemRec.Get("No.") then begin
                                if PlaylistHeaderRec.Get("Playlist No.") then begin
                                    if ItemRec."Radio Show Type" <> PlaylistHeaderRec."Radio Show Type" then
                                        Error('Il tipo di programma dell''''articolo (%1) non corrisponde al tipo di programma della Playlist Header (%2).',
                                ItemRec."Radio Show Type",
                                PlaylistHeaderRec."Radio Show Type"
                            );
                                end else
                                    Error('La Playlist Header con il numero %1 non è stata trovata.', "Playlist No.");

                                Description := ItemRec.Description;
                                Duration := ItemRec.Duration;
                                "Data Format" := ItemRec."Data Format";

                                "Royalty Cost" := ItemRec."Unit Cost";

                                if ItemRec."Data Format" = "Data Format"::Advertisement then
                                    "Advertising Revenue" := ItemRec."Unit Price";
                            end else
                                Error('L''''articolo con il numero %1 non è stato trovato.', "No.");
                        end;

                    else
                        Error('Tipo selezionato non valido. Sono supportati solo Resource o Item.');
                end;
            end;
        }
        field(30; "Data Format"; Enum "Data Format Type")            //Creating a field in the table.
        {
            Caption = 'Data Format';                                 //It's used to change the name when it is translated.
        }
        field(50; Description; Text[50])                             //Creating a field in the table.
        {
            Caption = 'Description';                                 //It's used to change the name when it is translated.
        }
        field(60; Duration; Duration)                                //Creating a field in the table.
        {
            Caption = 'Duration';                                    //It's used to change the name when it is translated.
            Editable = false;                                        //Sets a value that indicates whether a field, page, or
                                                                     //control can be edited through the UI.
        }
        field(70; "Start Time"; Time)                                //Creating a field in the table.
        {
            Caption = 'Start Time';                                  //It's used to change the name when it is translated.

            trigger OnValidate()
            begin
                if Duration <> 0 then                                //Check if the Duration is not equal to 0.
                    "End Time" := "Start Time" + Duration;           //Calculate the End Time by adding the Duration to the Start Time.
            end;
        }
        field(80; "End Time"; Time)                                  //Creating a field in the table.
        {
            Caption = 'End Time';                                    //It's used to change the name when it is translated.
            Editable = false;                                        //Sets a value that indicates whether a field, page, or
                                                                     //control can be edited through the UI.
        }
        field(90; "Royalty Cost"; Decimal)                           //Creating a field in the table.
        {
            Caption = 'Royalty Cost';                                //It's used to change the name when it is translated.
        }
        field(100; "Advertising Revenue"; Decimal)                   //Creating a field in the table.
        {
            Caption = 'Advertising Revenue';                         //It's used to change the name when it is translated.
        }
    }

    keys
    {
        key(PK; "Playlist No.", "Line No.")                          //Defining a Primary key.
        {
            Clustered = true;                                        //A clustered index determines the physical order in which records
                                                                     //are stored in the table. Using a clustered key can improve the
                                                                     //time it takes to retrieve records.
        }
    }

}