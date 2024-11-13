pageextension 50145 ItemCardExt extends "Item Card"
{
    layout
    {
        addafter("No.")
        {
            field("MES Id"; Rec."MES Id")
            {
                ApplicationArea = All;
                trigger OnValidate()
                var
                    MESManagement: Codeunit "MES Management";
                begin
                    MESManagement.CheckMESId(Rec."MES Id");
                end;
            }
        }
    }
}