page 50126 MagazineCategoryList
{
    PageType = List;
    ApplicationArea = All;
    SourceTable = MagazineCategory;
    UsageCategory = Administration;

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field(Code; Rec.Code)
                {
                    ApplicationArea = All;
                }
                field(Description; Rec.Description)
                {
                    ApplicationArea = All;
                }
            }
        }
    }
}