page 50127 MagazineListPage
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = Magazine;
    CardPageId = MagazineCard;                             //Al doppio click della lista devo poter aprire la card.

    layout
    {
        area(Content)
        {
            repeater(Group)
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
}