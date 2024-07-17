pageextension 50106 "ITS CustomerList Extension" extends "Customer List"
{

    actions
    {
        addfirst(Processing)      //Processing, Navigation, Creation e Reporting sao os agrupamentos que podem ser utilizados.
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
        }
    }
    var
        VarIntGlobal: Integer;

    trigger OnOpenPage()
    begin
        VarIntGlobal := 5;
    end;
}