table 50125 Magazine
{

    fields
    {
        field(1; "No."; Code[20])
        {

        }
        field(2; Name; Text[50])
        {

        }
        field(3; Category; Code[20])
        {
            TableRelation = MagazineCategory;
        }
        field(4; "Publication Frequency"; Enum "Publication Frequency")
        {

        }
        field(5; "Articles No."; Integer)
        {

        }
        field(6; "Ads No."; Integer)
        {

        }
    }
}