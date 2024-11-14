table 50104 "Publication Header"
{

    fields
    {
        field(1; "No."; Code[20])
        {
            Caption = 'No.';
        }
        field(2; "Magazine No."; Code[20])
        {
            Caption = 'Magazine No.';
            TableRelation = Magazine;
            trigger OnValidate()
            var
                MagazineRec: Record Magazine;
            begin
                if MagazineRec.Get("Magazine No.") then begin
                    Rec."Description" := StrSubstNo('%1 - %2', MagazineRec.Name, Rec."No.");
                end;
            end;
        }
        field(3; Number; Integer)
        {
            Caption = 'Number';
        }
        field(4; "Description"; Text[100])
        {
            Caption = 'Description';
        }
        field(5; "Publication Date"; Date)
        {
            Caption = 'Publication Date';
        }
    }

    keys
    {
        key(Key1; "No.")
        {
            Clustered = true;
        }
    }
}