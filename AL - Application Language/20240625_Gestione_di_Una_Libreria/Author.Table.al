table 50100 Author                //usar o comando ttable para criar uma tabela pre formatada
{

    fields
    {
        field(1; "No."; Code[20])
        {

        }

        field(2; Name; Text[50])
        {

        }
        field(3; "Country Code"; Code[10])
        {
            TableRelation = "Country/Region".Code;
        }
        field(4; "Country Name"; Code[50])
        {

        }

    }

    keys
    {
        key(Key1; "No.")
        {
            Clustered = true;                           //so se usa na chave primaria
        }
    }

}