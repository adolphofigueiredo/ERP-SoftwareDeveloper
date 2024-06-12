page 50100 "Book List"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = Book;

    layout
    {
        area(Content)
        {
            group(GroupName)
            {
                field(Code; Rec.Code)
                {
                    ApplicationArea = All;

                }
                field(ISBN; Rec.ISBN)
                {
                    ApplicationArea = All;

                }
                field(Title; Rec.Title)
                {
                    ApplicationArea = All;

                }
                field(Description; Rec.Description)
                {
                    ApplicationArea = All;

                }
                field(Author; Rec."Author No.")
                {
                    ApplicationArea = All;

                }
            }
        }
    }

}