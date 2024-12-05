report 50136 "Customer Report"
{
    UsageCategory = ReportsAndAnalysis;          //Serve para ligar o relatorio ao menu do business central.
    ApplicationArea = All;
    DefaultRenderingLayout = LayoutWord;         //Especificar o nome do laout que sera utilizado(olhar mais para baixo).

    dataset
    {
        dataitem(CustomerDataItem; Customer)
        {
            column(No_; "No.") { }
            column(Name; Name) { }
            column(E_Mail; "E-Mail") { }
            column(Balance__LCY_; "Balance (LCY)") { }
            column(Company_Info; CompanyName()) { }

            column(Report_Date; Format(Today())) { }

            /*dataitem("Sales Header"; "Sales Header")
            {
                DataItemLink = "Sell-to Customer No." = field("No.");
                column(Document_Type; "Document Type") { }
                column(Salles_No_; "No.") { } //O nome das colunas deve ser univoco
                column(Document_Date; "Document Date") { }
            }*/
        }
    }

    //Rendering é il tag che contiene la definizione dei layout nel vostro caso avrete sempre un solo layout di tipo word.

    rendering
    {
        layout(LayoutWord) //deve ser igual ao nome usado acima.
        {
            Type = Word;                        //è o tipo do relatorio que sera feito.
            LayoutFile = 'ListaCliente.docx';
        }
    }

    var
        myInt: Integer;
}