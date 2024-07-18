pageextension 50118 "Vendor Card Extension" extends "Vendor Card"
{
    layout
    {
        addfirst(General)
        {
            group(Professor)
            {
                field("Prof. Fiscal Code"; Rec."Prof. Fiscal Code")
                {
                }
                field("Prof. Full Name"; Rec."Prof. Full Name")
                {
                }
            }
        }
    }

    actions
    {
        addfirst(Navigation)

        {
            action("Show List")
            {
                Caption = 'Mostra Lista Moduli';
                ApplicationArea = All;

                trigger OnAction()
                begin

                end;
            }

            // 15) Nella pagina "Vendor Card" inserire un pulsante nel menu "Navigation",
            // con caption "Mostra Lista Moduli", che apra la lista dei moduli collegati
            // al vendor. Questo pulsante deve essere abilitato solo se il campo
            // "Prof.Fiscal Code" è stato compilato.        
        }

    }

    var
        myInt: Integer;
}