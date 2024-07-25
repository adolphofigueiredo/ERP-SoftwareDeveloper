pageextension 50106 "ITS CustomerList Extension" extends "Customer List"
{

    actions
    {
        addfirst(Processing)      //Processing - Azioni, Navigation - Correlato, Creation
                                  //e Reporting sao os agrupamentos que podem ser utilizados.
        {
            action("Message Trigger")
            {
                ApplicationArea = All;
                Caption = 'Message Trigger 02';
                Image = CarryOutActionMessage;

                trigger OnAction()
                var
                    VarInt: Integer;
                begin
                    VarInt += 2;
                    Message('La variabile contiene il valore %1.', VarInt);
                end;
            }
            action("IF Trigger 02")
            {
                ApplicationArea = All;
                Caption = 'IF Trigger 02';
                Image = IndentChartOfAccounts;

                trigger OnAction()
                begin
                    if VarIntGlobal >= 10 then begin
                        Message('La variabile VarIntGlobal è maggiore uguale a 10. ( %1 )', VarIntGlobal);
                        VarIntGlobal -= 2;
                    end else begin
                        Message('La variabile VarIntGlobal è inferiore a 10. ( %1 )', VarIntGlobal);
                        VarIntGlobal += 2;
                    end;
                end;

            }
            action("Loop Trigger 02")
            {
                ApplicationArea = All;
                Caption = 'Loop Trigger 02';
                Image = Refresh;

                trigger OnAction()
                var

                    Esponente: Integer;
                    I: Integer;
                    Result: Integer;
                    Base: Integer;

                begin

                    Esponente := 4;
                    Result := 1;
                    Base := 2;

                    for I := 1 to Esponente do begin
                        Result *= Base;
                    end;
                    Message('La potenza di %1 alla %2 è %3.', Base, Esponente, Result);
                end;
            }
            action(EsempiLettura)                       //Esse botao nao faz muito sentido, mas esta sendo
                                                        //explicado como usar a funcao get na tabela.
            {
                ApplicationArea = All;
                Caption = 'Esempi Lettura';

                trigger OnAction()
                var
                    ItemRec: Record Item;
                begin
                    //ricerca per chiave primaria
                    //Rec.Get('1908-S-NonEsiste');
                    //Message(ItemRec.Description);

                    //primo elemento tramite ricerca senza chiave
                    //Rec.FindFirst();
                    //Message(ItemRec.Description);

                    //ultimo elemento tramite ricerca senza chiave
                    //Rec.FindLast();
                    //Message(ItemRec.Description);

                    //Prendo l'ultimo elemento filtrati per tipo
                    ItemRec.SetRange(type, Enum::"Item Type"::Inventory);
                    ItemRec.FindLast();
                    Message(ItemRec.Description);

                end;
            }
            action("Cust. Count by Region")
            {
                Caption = 'Cust. Count by Region';
                Image = CountryRegion;
                ApplicationArea = All;
                trigger OnAction()
                var
                    CustomerVar: Record Customer;
                    CountryVar: Record "Country/Region";
                    Counter: Integer;
                begin
                    CountryVar.Get(Rec."Country/Region Code");
                    CustomerVar.SetRange("Country/Region Code", Rec."Country/Region Code");
                    //CustomerVar.SetFilter("Country/Region Code",'<>%1',Rec."Country/Region Code"); //exemplo de filtro
                    if CustomerVar.FindSet() then
                        repeat
                            Counter += 1;
                        until CustomerVar.Next() = 0;
                    Message('I clienti per la nazione %1 sono %2.', CountryVar.Name, Counter);
                end;
            }
            action("Calc. Sales Order Amount") // igual ao botom de baixo mas calculado de maneira diferente
            {
                ApplicationArea = All;
                Caption = 'Calc. Sales Order Amount';
                Image = AddWatch;

                trigger OnAction()
                var
                    SalesHeaderVar: Record "Sales Header";
                    TotalAmountVar: Decimal;
                begin
                    SalesHeaderVar.SetRange("Sell-to Customer No.", Rec."No.");
                    SalesHeaderVar.SetRange("Document Type", Enum::"Sales Document Type"::Order);       //modo de fazer um filtro por enumeracao
                    if SalesHeaderVar.FindSet() then
                        repeat
                            SalesHeaderVar.CalcFields(Amount);              //Funcao usada porque existia calculos na tabela referencia. Esta
                                                                            //funcao determina que o valor sera calculado antes de ser enviado.
                            TotalAmountVar += SalesHeaderVar.Amount;
                        until SalesHeaderVar.Next() = 0;
                    Message('Limporto totale degli ordini di vendita per il cliente %1 è: €%2.', Rec.Name, TotalAmountVar);
                end;
            }

            action("Calc. Sales Order Amount 02") // igual ao botom de cima mas calculado de maneira diferente
            {
                ApplicationArea = All;
                Caption = 'Calc. Sales Order Amount 02';
                Image = Calculate;

                trigger OnAction()
                var
                    SalesLineRec: Record "Sales Line";
                    TotalAmountVar: Decimal;

                begin
                    SalesLineRec.SetRange("Sell-to Customer No.", Rec."No.");                       //primeiro filtro de acordo com o numero do cliente.
                    SalesLineRec.SetRange("Document Type", Enum::"Sales Document Type"::Order);     //Segundo filtro de acordo com o tipo de documento de venda.
                                                                                                    //modo de fazer um filtro por enumeracao
                                                                                                    // Era possivel escrever SalesLineRec.SetRange("Document Type", 1);
                                                                                                    // Era possivel escrever SalesLineRec.SetRange("Document Type", SalesLineRec."Document Type"::Order);
                                                                                                    // E indiferente o modo, basta escolher um.

                    if SalesLineRec.FindSet() then
                        repeat
                            TotalAmountVar += SalesLineRec.Amount;
                        until SalesLineRec.Next() = 0;
                    Message('Limporto totale degli ordini di vendita per il cliente %1 è: €%2.', Rec.Name, TotalAmountVar);
                end;
            }
            action("Edit Description")
            {
                ApplicationArea = All;
                Caption = 'Edit Description';
                Image = Camera;
                trigger OnAction()
                var
                    CustomerVar: Record Customer;
                    TextVar: Text;
                begin
                    TextVar := ' - Edited';
                    CustomerVar.Get(Rec."No.");
                    CustomerVar.Name += TextVar;
                    CustomerVar.Modify();

                    // Rec.Name := Rec.Name + ' - Edited';   Seria mais simples ter escrito desta maneira
                    // Rec.Modify();                         Seria mais simples ter escrito desta maneira
                end;
            }
        }
        addlast(processing)
        {
            action("Delete Comments")               //para entender os filtros utilizados no programa e que eu devo usar e so usar o ctrl + alt +f1
                                                    //na paguina utilizada e olhar nos filtros da pagina, repare que sao os mesmos usados no SetRange
            {
                ApplicationArea = All;
                Caption = 'Delete Comments';
                Image = Delete;
                trigger OnAction()
                var
                    CommentLine: Record "Comment Line";
                begin
                    CommentLine.SetRange("Table Name", CommentLine."Table Name"::Customer); //modo de fazer um filtro por enumeracao
                    CommentLine.SetRange("No.", Rec."No.");
                    if CommentLine.FindSet() then               //ao inves de fazer o ciclo poderia ter sido usado o deleteall
                        repeat
                            CommentLine.Delete();
                        until CommentLine.Next() = 0;
                end;
            }
        }
        addfirst(navigation)      //Processing - Azioni, Navigation - Correlato, Creation
                                  //e Reporting sao os agrupamentos que podem ser utilizados.
        {
            action("Show Country")
            {
                ApplicationArea = All;
                Image = Absence;
                Caption = 'Show Country';
                trigger OnAction()
                var
                    CountryVar: Record "Country/Region";                //Primeiro digo que tabela acessar e crio a variavel
                                                                        //que recebera os valores. Veja que a variavel é do tipo Record.
                begin
                    CountryVar.Get(Rec."Country/Region Code");          //Agora estou dizendo a variavel que recebera todas as informacoes daquela
                                                                        //linha. Lembre que esta variavel receber todas as informacoes deste registro
                                                                        //da tabela dita antes.

                    Message('Cliente: %1 - Nazione: %2', Rec.Name, CountryVar.Name);   //Agora na VarNaz eu estou dizendo que
                                                                                       //so quero imprimir o nome e nao todas as informacoes.
                end;
            }
        }
    }
    var
        VarIntGlobal: Integer;

    trigger OnOpenPage()
    begin
        VarIntGlobal := 5;
    end;
}