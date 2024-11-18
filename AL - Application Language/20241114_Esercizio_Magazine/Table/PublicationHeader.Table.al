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
                PublicationHdr: Record "Publication Header";
            begin
                MagazineRec.Get(Rec."Magazine No.");
                Rec."Description" := MagazineRec.Name;

                PublicationHdr.SetRange("Magazine No.", Rec."Magazine No.");
                if PublicationHdr.FindLast() then
                    Rec.Number := PublicationHdr.Number + 1
                else
                    Rec.Number := 1;

                Rec.Description := MagazineRec.Name + ' - ' + Format(Rec.Number);
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