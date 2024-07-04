pageextension 50103 "ITS Customer List Extension" extends "Customer List"
{
    actions
    {
        addfirst(processing)                                                   //Processing em italiano significa Azioni
        {
            action(ActionExample)                                              //Creazione di un pulsante
            {
                Image = Action;
                Caption = 'Prova Trigger';
                ApplicationArea = All;
                trigger OnAction()                                             //Creazione di azioni dopo di premere il pulsante
                var
                    VarInt: Integer;

                begin
                    //Assegnare valore 20 a una variabile intera
                    VarInt := 20;
                    //stampare un messaggio con un intero dato da una variabile
                    Message('List - La variabile intera vale: %1.', VarInt);   //este %1 +e usado para concatenar variaveis de tipos
                                                                               //diferentes, no caso uma str com um integer. Se tiver
                                                                               //mais pode usar %2, %3 e assim vai.
                                                                               //Stampa variabile globale
                    Message(VarGlobal);
                    //Assegnazione variabile globale
                    VarGlobal := 'Messaggio Globale';
                    //Stampa variabile globale
                    Message(VarGlobal);
                end;
            }
            action(ControlExample)
            {
                ApplicationArea = All;
                Caption = 'Esempio Controlli';
                Image = TestFile;

                trigger OnAction()                                             //Enquanto o trigger nao e criado, o botao nao
                                                                               //aparece no business central
                begin
                    //stampare un messaggio 'Variable globale inferiore a 10'
                    //oppure stampare un messaggio 'Variabile globale maggiore o uguale a 10'
                    //sulla base della variabile globale VarIntGlobal
                    if VarIntGlobal >= 10 then begin
                        Message('Variabile globale maggiore o uguale a 10');
                        VarIntGlobal -= 2;
                    end
                    else begin
                        Message('Variable globale inferiore a 10');

                        //Incrementare di 2 la variabile
                        //VarIntGlobal := VarIntGlobal + 2;
                        VarIntGlobal += 2;
                    end;
                end;
            }
        }
    }
    var
        VarGlobal: Text;                                                       //Variabile Globale
        VarIntGlobal: Integer;

    trigger OnOpenPage()
    begin
        VarGlobal := 'init';
        VarIntGlobal := 9;
    end;
}