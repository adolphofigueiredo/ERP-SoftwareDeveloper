tableextension 50101 "ITS Customer Extension" extends Customer
{
    fields
    {
        field(50102; "Bill-to Address Exist"; Boolean)
        {
            Caption = 'Esiste Indirizzo di fatturazione';
            FieldClass = FlowField;
            CalcFormula = exist("ITS Bill-To Address" where("Customer No." = field("No.")));
            //primeiro digo a tabela que deve ir procurar, depois usando where devo dizer o campor
            //que deve procurar e depois dizer onde olhar na propria tabela
        }
    }
}