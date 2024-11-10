codeunit 50100 "Sales Price Management"
{
    // collegamento all'evento di rilascio del documento di vendita
    [EventSubscriber(ObjectType::Codeunit, Codeunit::"Release Sales Document", 'OnBeforeReleaseSalesDoc', '', false, false)]
    local procedure OnBeforeReleaseSalesDoc(var SalesHeader: Record "Sales Header"; PreviewMode: Boolean; var IsHandled: Boolean; SkipCheckReleaseRestrictions: Boolean)
    var
        SalesLine: Record "Sales Line";
        Price: Decimal;
    begin
        // filtro tutte le righe collegate alla testata dell'OdV passata come parametro all'evento
        SalesLine.SetRange("Document Type", SalesHeader."Document Type");
        SalesLine.SetRange("Document No.", SalesHeader."No.");
        SalesLine.SetRange(Type, Enum::"Sales Line Type"::Item);
        if SalesLine.FindSet() then
            // ciclo le righe trovate
            repeat
                // per ogni riga calcolo il prezzo minore dal listino prezzi
                Price := GetSalesUnitPrice(SalesLine."Sell-to Customer No.", SalesLine."No.", SalesLine.Quantity);
                // se trovo un prezzo inferiore allora chiedo conferma all'utente per proseguire 
                if (Price > 0) and (SalesLine."Unit Price" > Price) then begin
                    if not Confirm('Trovato prezzo inferiore per la riga %1 dell''ordine %2, continuare?',
                                    true, SalesLine."Line No.", SalesLine."Document No.") then
                        Error('Esecuzione interrotta');

                    // se l'utente seleziona OK modifico il prezzo di vendita con quello trovato
                    SalesLine.Validate("Unit Price", Price);
                    SalesLine.Modify(true);
                end
            until SalesLine.Next() = 0;
    end;

    // funzione per trovare il prezzo minimo dati in input i dati di cliente, articolo e quantità
    procedure GetSalesUnitPrice(CustomerNo: Code[20]; ItemNo: Code[20]; Quantity: Integer): Decimal
    var
        SalesPriceLines: Record "Sales Price Lines";
        Item: Record Item;
    begin
        // ordina i prezzi per unit price per prendere il più piccolo
        SalesPriceLines.SetCurrentKey("Unit Price");
        SalesPriceLines.Ascending(true);
        // imposta i filtri per cliente, articolo e quantità passati in input alla funzione
        SalesPriceLines.SetRange("Customer No.", CustomerNo);
        SalesPriceLines.SetRange("Item No.", ItemNo);
        SalesPriceLines.SetFilter("Min. Qty", '<=%1', Quantity);
        // imposta il filtro per trovare solo i record Abilitati
        SalesPriceLines.SetRange(Enabled, true);
        // se ne trovo almeno uno e lo prende dal database
        if SalesPriceLines.FindFirst() then
            // allora ritorna il valore dello Unit Price trovato 
            exit(SalesPriceLines."Unit Price")
        else begin
            // altrimenti va a prendere l'articolo collegato
            Item.Get(ItemNo);
            // e ritorna il valore Unit price dell'articolo
            exit(Item."Unit Price");
        end;
    end;

    // Date in input N righe di prezzi, creare un ordine di vendita (OdV) con le righe create a partire dalle righe di prezzo
    procedure CreateSalesOrderFromSalesPrice(var SalesPriceLines: Record "Sales Price Lines")
    var
        SalesHeader: Record "Sales Header";
        SalesLine: Record "Sales Line";
        CustomerNo: Text;
        LineNo: Integer;
    begin
        // Se trovo almeno una riga di prezzo
        if SalesPriceLines.FindSet() then begin
            // inizio creando la testata dell'OdV
            SalesHeader.Init();
            SalesHeader."Document Type" := Enum::"Sales Document Type"::Order;
            SalesHeader.Validate("Sell-to Customer No.", SalesPriceLines."Customer No.");
            SalesHeader.Insert(true);

            // imposto la variabile per il controllo del customer (tutte le righe di prezzo devono avere lo stesso customer)
            CustomerNo := SalesPriceLines."Customer No.";

            // inizio il ciclo per ogni riga di prezzo passata alla funzione
            repeat
                // se la riga di prezzo ha una customer diverso da quello impostato sulla testata dell'OdV
                if CustomerNo <> SalesPriceLines."Customer No." then
                    // allora vai in errore perchè tutte le righe di prezzo devono avere lo stesso customer
                    Error('Riga %1 ha customer no diverso dalle altre', SalesPriceLines."Entry No.");

                // richiama la funzione per creare una riga di OdV dalla riga di prezzo
                LineNo += 10000;
                CreateSalesLineFromSalesPrice(SalesHeader, LineNo, SalesPriceLines);
            until SalesPriceLines.Next() = 0;
        end;
    end;

    // data la testata di un OdV e una riga di prezzo, scrivere una riga di OdV
    local procedure CreateSalesLineFromSalesPrice(SalesHeader: Record "Sales Header"; LineNo: Integer;
                                                    SalesPriceLines: Record "Sales Price Lines")
    var
        SalesLine: Record "Sales Line";
    begin
        SalesLine.Init();
        // si inizia impostando la chiave della riga di OdV
        SalesLine."Document Type" := SalesHeader."Document Type";
        SalesLine."Document No." := SalesHeader."No.";
        SalesLine."Line No." := LineNo;

        // si continua impostando tutti i campi della riga a partire dalla riga di prezzo: cliente, articolo, qta e prezzo
        SalesLine.Validate("Sell-to Customer No.", SalesPriceLines."Customer No.");
        SalesLine.Validate(Type, Enum::"Sales Line Type"::Item);
        SalesLine.Validate("No.", SalesPriceLines."Item No.");
        SalesLine.Validate(Quantity, SalesPriceLines."Min. Qty");
        SalesLine.Validate("Unit Price", SalesPriceLines."Unit Price");
        // senza l'insert la riga non viene salvata su database
        SalesLine.Insert(true);
    end;
}