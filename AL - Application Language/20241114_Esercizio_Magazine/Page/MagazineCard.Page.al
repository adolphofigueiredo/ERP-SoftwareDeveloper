page 50125 MagazineCard
{
    PageType = Card;
    ApplicationArea = All;
    UsageCategory = Administration;
    SourceTable = Magazine;

    layout
    {
        area(Content)
        {
            group(Group)
            {
                field("No."; Rec."No.")
                {
                    ApplicationArea = All;
                }
                field(Name; Rec.Name)
                {
                    ApplicationArea = All;
                }

                field(Category; Rec.Category)
                {
                    ApplicationArea = All;
                }
                field("Publication Frequency"; Rec."Publication Frequency")
                {
                    ApplicationArea = All;
                }
                field("Articles No."; Rec."Articles No.")
                {
                    ApplicationArea = All;
                }
                field("Ads No."; Rec."Ads No.")
                {
                    ApplicationArea = All;
                }
            }
        }
    }
    actions
    {
        area(Processing)
        {
            action(Program)
            {
                ApplicationArea = All;
                Caption = 'Programma';
                trigger OnAction()
                begin

                end;
            }
        }
    }
}