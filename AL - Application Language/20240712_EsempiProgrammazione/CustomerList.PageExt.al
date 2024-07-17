pageextension 50105 "ITS Customer List Extension" extends "Customer List" //Ja existe uma ITS Customer List Extension e nao tem problema repetir o nome.
                                                                          //verificar se deve trocar o nome. O problema é quando repete o ID.
{
    actions
    {
        addfirst(processing)
        {
            action("Message Trigger01")
            {
                ApplicationArea = All;
                Image = Workflow;
                Caption = 'Scatenare Messaggio';                          //Nao usar caption em pagina
                ToolTip = 'Press to read a message.';
                trigger OnAction()
                var
                    Valore: Integer;
                begin
                    Valore := 2;
                    Message('La variabile contiene il valore %1.', Valore);
                    Message('Test variabile globale %1.', VarIntGlobal);
                end;
            }
            action("IF Trigger")
            {
                ApplicationArea = All;
                Image = Administration;
                Caption = 'If Trigger / If Trigger';                      //Nao usar caption em pagina
                ToolTip = 'Pressione para ler a mensagem.';
                trigger OnAction()
                begin
                    if VarIntGlobal >= 10 then begin
                        Message('Variabile VarIntGlobal maggiore o uguale a 10. (%1)', VarIntGlobal);
                        VarIntGlobal -= 2;
                    end
                    else begin
                        Message('Variabile VarIntGlobal minore di 10. (%1)', VarIntGlobal);
                        VarIntGlobal += 2;
                    end;
                end;
            }
            action("Loop Trigger")
            {
                ApplicationArea = All;
                Image = Account;
                Caption = 'Loop Trigger / Loop Trigger';                  //Nao usar caption em pagina
                ToolTip = 'Press to calculate.';
                trigger OnAction()
                var
                    Potenza: Integer;
                    Risultato: Integer;
                    I: Integer;
                begin
                    Potenza := 5;
                    Risultato := 1;
                    for I := 1 to Potenza do begin
                        Risultato *= 2;
                    end;
                    Message('La potenza di 2 alla %1 è %2.', Potenza, Risultato);
                end;
            }
        }
    }

    var
        VarIntGlobal: Integer;                                      //Se declarar a variavel dentro do trigger
                                                                    //ela nao sera uma variavel global.
    trigger OnOpenPage()
    begin
        VarIntGlobal := 5;
    end;
}