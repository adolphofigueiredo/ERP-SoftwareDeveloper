//https://learn.microsoft.com/en-us/dynamics365/business-central/dev-itpro/developer/devenv-table-ext-object
//é uma tabela criada para fazer uma extensao em uma
//tabela padrao da microsoft ou em uma tabela que se
//for modificada pode criar problemas . Nao faz sentido
//criar uma extensao em uma tabela que eu posso modificar.
tableextension 50100 ITSItemTableExt extends Item
{
    fields
    {
        field(50101; "Book No."; Code[20])
        //o numero do campo parte do primeiro numero da
        //extensao nao é o mesmo que uma tabela nomral
        //que comeca do um em diante.
        {
            Caption = 'Book No.';
        }
        field(50102; "Book Title"; Text[50])
        //o numero do campo parte do primeiro numero da
        //extensao nao é o mesmo que uma tabela nomral
        //que comeca do um em diante.
        {
            Caption = 'Book Title';
            FieldClass = FlowField;
            CalcFormula = lookup("ITS Book".Title where("No." = field("Book No.")));
        }
    }
}