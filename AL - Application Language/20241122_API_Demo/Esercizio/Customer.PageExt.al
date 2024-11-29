pageextension 50101 CustomerPageExt extends "Customer Card"
{
    layout
    {
        addfirst(content)
        {
            field(API; Rec.API)
            {
                ApplicationArea = All;
            }
        }
    }

    actions
    {
        // Add changes to page actions here
    }

    var
        myInt: Integer;
}