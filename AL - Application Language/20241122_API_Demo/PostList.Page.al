page 50101 "Post List"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = Post;

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field(Id; Rec.Id)
                { }
                field("User Id"; Rec."User Id")
                { }
                field("External Id"; Rec."External Id")
                { }
                field(Title; Rec.Title)
                { }
                field(Body; Rec.Body)
                { }
            }
        }
        area(Factboxes)
        { }
    }

    actions
    {
        area(Processing)
        {
            action(DeleteAllPost)
            {
                Image = DeleteRow;
                ApplicationArea = All;
                Caption = 'Delete All Posts';

                trigger OnAction()
                var
                    Post: Record Post;
                begin
                    Post.DeleteAll();
                    CurrPage.Update();
                end;
            }
        }
    }
}