pageextension 50100 PE50100 extends "Item Card"
{
    layout
    {
        addfirst(content)
        {
            group(Magazine)
            {
                Caption = 'Magazine';
                field("Article Type"; Rec."Article Type")
                {
                    ApplicationArea = All;
                }
                field("Magazine Category"; Rec."Magazine Category")
                {
                    ApplicationArea = All;
                }
                field("Published No."; Rec."Published No.")
                {
                    ApplicationArea = All;
                }
                field("Publishing No."; Rec."Publishing No.")
                {
                    ApplicationArea = All;
                }
                field("Publishing Max No."; Rec."Publishing Max No.")
                {
                    ApplicationArea = All;
                }
            }
        }
    }

}