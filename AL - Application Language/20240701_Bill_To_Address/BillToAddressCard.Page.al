page 50114 "ITS Bill-To Address Card"
{
    Caption = 'Inidirizzo di fatturazione';
    PageType = Card;
    ApplicationArea = All;
    //UsageCategory = Administration; //deve essere messa solo se a pagina va a menu.
    SourceTable = "ITS Bill-To Address";


    layout
    {
        area(Content)
        {
            group(General)
            {
                Caption = 'Generale';
                field("Entry No."; Rec."Entry No.")
                {
                    ApplicationArea = All;
                    Editable = false;
                }
                field("Customer No."; Rec."Customer No.")
                {
                    ApplicationArea = All;
                }
                field(Name; Rec.Name)
                {
                    ApplicationArea = All;
                }
            }
            group(Data)
            {
                Caption = 'Dati';
                field(Address; Rec.Address)
                {
                    ApplicationArea = All;
                }
                field("Country/Region Code"; Rec."Country/Region Code")
                {
                    ApplicationArea = All;
                }
                field(City; Rec.City)
                {
                    ApplicationArea = All;
                }
            }
        }
    }

    var
        myInt: Integer;
}