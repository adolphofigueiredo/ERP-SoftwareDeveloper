report 50101 "Customer Ledger Entry"
{
    UsageCategory = ReportsAndAnalysis;                                        //Se nao usar este comando, o relatorio nao sera encontrado na pesquisa. O nome que deve ser pesquisado è o mesmo nome usado na linha 1.
    ApplicationArea = All;                                                     //Também serve para ser usado na pesquisa do menu.
    DefaultRenderingLayout = LayoutName;

    dataset
    {
        dataitem(CustLedgerEntry; "Cust. Ledger Entry")                        //Aqui insiro a tabela que sera usadas e abaixo as colunas que serao utilizadas no relatorio.
        {
            column(Posting_Date; Format("Posting Date")) { }                   //O format deve ser usado para transformar em string e assim cortar a hora do date time e ficar so date.
            column(Document_Type; "Document Type") { }
            column(Document_No_; "Document No.") { }
            column(Description; Description) { }
            column(Amount; Amount) { }
            column(Customer_No; Customer."No.") { }
            column(Customer_Name; Customer.Name) { }
            column(Company_Name; CompanyName()) { }                            //Esta funcao serve para adicionar no relatorio o nome da empresa. Funcao CompanyName().
            column(ReportDate; Format(Today())) { }                               //Esta funcao serve para adicionar a data de hoje no relatorio. Funcao Today().
            trigger OnPreDataItem()
            begin
                CustLedgerEntry.SetRange("Customer No.", CustNo);
            end;
        }
    }

    requestpage
    {
        AboutTitle = 'Teaching tip title';
        AboutText = 'Teaching tip content';
        layout
        {
            area(Content)
            {
                group(GroupName)
                {
                    field(CustNo; CustNo)
                    {
                        Caption = 'Customer No.';
                        TableRelation = Customer;
                    }
                }
            }
        }
    }

    rendering
    {
        layout(LayoutName)
        {
            Type = Word;
            LayoutFile = 'CustomerLedgerEntry.Report.docx';
        }
    }

    var
        Customer: Record Customer;
        CustNo: Code[20];

    trigger OnPreReport()
    begin
        if CustNo = '' then
            Error('Devi inserire un numero cliente');
        Customer.Get(CustNo);
    end;
}