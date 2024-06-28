table 50101 "ITS Book"                 //Usar o comando ttable para criar uma tabela pre formatada.
{
    Caption = 'Book';                  //Usado para colocar um nome que pode ser traduzido e todos podem ver.
    fields
    {
        field(1; "No."; Code[20])
        {

        }
        field(2; Title; Text[50])
        {

        }
        field(3; Description; Text[250])
        {

        }
        field(4; "Author No."; Code[20])
        {
            TableRelation = "ITS Author";
        }
        field(5; "Author Name"; Text[50])
        {
            FieldClass = FlowField;
            CalcFormula = lookup("ITS Author".Name where("No." = field("Author No.")));
            //falando da formula a cima primeiro digo onde buscar e o que buscar
            //depois where seguido do campo que deve ir de encontro na linha que
            //eu quero seguido do campo que eu tenho no momento.
        }
        field(6; Date; Date)
        {
        }
        field(7; Price; Decimal)
        {
        }
        field(8; Discount; Enum "ITS Book Discount")
        {                              //Usei F2 e renomeia o campo 
        }                              //e todas as suas referencias
        field(9; Quantity; Integer)
        {
        }
        field(10; "Book Series No."; Code[20])
        {
            TableRelation = "ITS Book Series";
        }
    }

    keys
    {
        key(Key1; "No.")
        {
            Clustered = true;
        }
        key(Key2; Title)
        {

        }
        key(Key3; "Author No.", Date)
        {

        }
    }
}