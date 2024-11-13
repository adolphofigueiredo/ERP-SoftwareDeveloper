codeunit 50145 "MES Management"
{
    procedure CheckMESId(var "MES Id": Code[20]): Boolean           //O var é usada pois vc esta mandando a referencia do campo
                                                                    //e nao uma copia do campo, ou seja, deste modo estou
                                                                    //possibilitando que dentro da procedura ele seja alterado
    var

        I: Integer;
        TypeHelper: Codeunit "Type Helper";

    begin

        //Controllo del campo MES ID all'inserimento.
        //Deve essere compost da prefisso MES.
        //Deve essere compost da corpo 03 lettere.
        //Deve essere compost da sufisso di 02 cifre.
        //Esempio: MESART02.
        //Esempio sbagliato: MESARTICOLO1100.

        if StrLen("MES Id") <> 8 then
            Error('Compilare MES Id correttamente, numero di caratteri diverso da 8.');

        if CopyStr("MES Id", 1, 3) <> 'MES' then
            Error('Prefisso diverso da MES.');

        for I := 4 to 6 do begin
            if TypeHelper.IsDigit("MES Id"[I]) then
                Error('I caratteri in posizione 4-6 devono essere delle lettere.');
        end;

        for I := 7 to 8 do begin
            if not TypeHelper.IsDigit("MES Id"[I]) then
                Error('I caratteri in posizione 7-8 devono essere delle cifre.');
        end;

        exit(true)                                                   //Neste caso estou usando o booleano so para mostrar que
                                                                     //posso retornar um valor para quem chamou a procedure.
    end;
}