report 50101 "Customer Ledger Entry"
{
    UsageCategory = ReportsAndAnalysis;
    ApplicationArea = All;
    DefaultRenderingLayout = LayoutName;

    dataset
    {
        dataitem(CustLedgerEntry; "Cust. Ledger Entry")
        {
            column(Posting_Date; Format("Posting Date")) { }
            column(Document_Type; "Document Type") { }
            column(Document_No_; "Document No.") { }
            column(Description; Description) { }
            column(Amount; Amount) { }
            column(Customer_No; Customer."No.") { }
            column(Customer_Name; Customer.Name) { }
            column(Company_Name; CompanyName()) { }

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
            LayoutFile = 'CustomerLedgerEntry.docx';
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