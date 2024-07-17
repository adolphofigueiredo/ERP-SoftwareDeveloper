table 50000 "ITS Author"           //Usar o comando ttable para criar uma tabela pre formatada.
{
    Caption = 'Author';           //Usado para colocar um nome que pode ser traduzido e todos podem ver.
    fields                        //Quando usa '' se diz que ali dentro tem uma string.
    {                             //O business central nao gerencia um campo null, ou seja, se nao tem valor ele insere 0.
        field(1; "No."; Code[20])
        {
            Caption = 'No.';
        }

        field(2; Name; Text[50])
        {
            Caption = 'Name';
        }
        field(3; "Country Code"; Code[10])
        {
            Caption = 'Country Code';
            TableRelation = "Country/Region".Code;
        }
        field(4; "Country Name"; Text[50])
        {
            Caption = 'Country Name';
        }

    }

    keys
    {
        key(Key1; "No.")
        {
            Clustered = true;     //so se usa na chave primaria
        }
    }

}