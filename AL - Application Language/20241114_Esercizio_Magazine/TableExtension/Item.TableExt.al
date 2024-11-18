tableextension 50125 TE50100 extends Item
{
    fields
    {
        field(50125; "Article Type"; Enum "Article Type")
        {

        }
        field(50126; "Magazine Category"; Code[20])
        {
            TableRelation = MagazineCategory;
        }
        field(50127; "Published No."; Integer)
        {
            //FieldClass = FlowField;
            //CalcFormula = Sum("Magazine Entry"."Entry No." WHERE("Item"."No." = field("No.")));
        }
        field(50128; "Publishing No."; Integer)
        {
            //FieldClass = FlowField;
            //CalcFormula = Sum("Publication Line"."Line No." WHERE("Item"."No." = field("No.")));
        }
        field(50129; "Publishing Max No."; Integer)
        {

        }
    }
}