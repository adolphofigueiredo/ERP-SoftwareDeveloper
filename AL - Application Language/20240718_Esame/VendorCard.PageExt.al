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
                Enabled = Rec."Prof. Fiscal Code" <> '';
                RunObject = page "Module List";
                RunPageLink = "Course No." = field("No.");
            }
        }
    }
    var
        myInt: Integer;
}