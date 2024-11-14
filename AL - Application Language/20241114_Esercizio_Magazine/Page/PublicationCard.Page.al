page 50105 "Publication Card"
{
    PageType = Document;
    SourceTable = "Publication Header";

    layout
    {
        area(Content)
        {
            group(General)
            {
                Caption = 'General';
                field("No."; Rec."No.")
                {
                    ApplicationArea = All;
                }
                field("Magazine No."; Rec."Magazine No.")
                {
                    ApplicationArea = All;
                }
                field(Number; Rec.Number)
                {
                    ApplicationArea = All;
                }
                field(Description; Rec.Description)
                {
                    ApplicationArea = All;
                }
                field("Publication Date"; Rec."Publication Date")
                {
                    ApplicationArea = All;
                }
            }
            part(PublicationLine; "Publication Subpage")
            {
                ApplicationArea = All;
                SubPageLink = "Publication No." = field("No.");
            }
        }
    }
    actions
    {
        area(Processing)
        {
            action(Register)
            {
                ApplicationArea = All;
                Caption = 'Registra';
                trigger OnAction()
                begin
                    Message('Estou aqui!!!!!');
                end;
            }
        }
    }
}