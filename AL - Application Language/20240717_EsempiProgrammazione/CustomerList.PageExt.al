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
                Image = Workflow;
                ApplicationArea = All;
                trigger OnAction()
                var
                    Customer: Record Customer;
                    CountryVar: Record "Country/Region";
                    Counter: Integer;
                begin
                    CountryVar.Get(Rec."Country/Region Code");
                    Customer.SetRange("Country/Region Code", Rec."Country/Region Code");
                    if Customer.FindSet() then
                        repeat
                            Counter += 1;
                        until (Rec.Next = 0);
                    Message('I clienti per la nazione %1 sono %2.', CountryVar.Name, Counter);
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
                                                                        //linha. Lembre que esta variavel receber todas as informacoes deste registro.

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