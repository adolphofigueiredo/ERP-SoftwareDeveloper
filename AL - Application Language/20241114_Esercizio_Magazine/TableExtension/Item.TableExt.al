tableextension 50125 TE50100 extends Item
{
    fields
    {
        field(50125; "Article Type"; Enum "Article Type")
        {
            trigger OnValidate()
            begin
                if "Article Type" = "Article Type"::Article then
                    "Publishing Max No." := 1;
            end;
        }
        field(50126; "Magazine Category"; Code[20])
        {
            TableRelation = MagazineCategory;
        }
        field(50127; "Published No."; Integer)
        {
            FieldClass = FlowField;
            CalcFormula = Count("Magazine Entry" where("No." = field("No.")));
        }
        field(50128; "Publishing No."; Integer)
        {
            FieldClass = FlowField;
            CalcFormula = Count("Publication Line" where("No." = field("No.")));
        }
        field(50129; "Publishing Max No."; Integer)
        {

        }
    }
}