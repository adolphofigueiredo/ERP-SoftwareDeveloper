codeunit 50100 "Sales Price Management"
{
    //Subscribing to the sales document release event.
    [EventSubscriber(ObjectType::Codeunit, Codeunit::"Release Sales Document", 'OnBeforeReleaseSalesDoc', '', false, false)]
    local procedure OnBeforeReleaseSalesDoc(var SalesHeader: Record "Sales Header"; PreviewMode: Boolean; var IsHandled: Boolean; SkipCheckReleaseRestrictions: Boolean)
    var
        SalesLine: Record "Sales Line";
        Price: Decimal;
    begin
        //Filter all the lines connected to the sales order header passed as a parameter to the event.
        SalesLine.SetRange("Document Type", SalesHeader."Document Type"); //Set the filters for document type.
        SalesLine.SetRange("Document No.", SalesHeader."No.");            //Set the filters for document number.
        SalesLine.SetRange(Type, Enum::"Sales Line Type"::Item);          //Set the filters for item type.
        if SalesLine.FindSet() then
            repeat                                                        //Loop through the found lines.
                                                                          //For each line, calculate the lowest
                                                                          //price from the price list.
                Price := GetSalesUnitPrice(SalesLine."Sell-to Customer No.", SalesLine."No.", SalesLine.Quantity);
                if (Price > 0) and (SalesLine."Unit Price" > Price) then begin //If a lower price is found, ask
                                                                               //the user for confirmation to proceed
                    if not Confirm('Trovato prezzo inferiore per la riga %1 dell''ordine %2, continuare?',   //If the user selects OK, update the
                                                                                                             //sales price with the found price.
                                    true, SalesLine."Line No.", SalesLine."Document No.") then
                        Error('Esecuzione interrotta');
                    SalesLine.Validate("Unit Price", Price);              //If the user selects OK, update the sales
                    SalesLine.Modify(true);                               //price with the found price.
                end
            until SalesLine.Next() = 0;
    end;

    procedure GetSalesUnitPrice(CustomerNo: Code[20]; ItemNo: Code[20]; Quantity: Integer): Decimal
    //Function created to find the minimum price given the input data for customer, item, and quantity.
    var
        SalesPriceLines: Record "Sales Price Lines";
        Item: Record Item;
    begin
        SalesPriceLines.SetCurrentKey("Unit Price");                 //Selecting a key for this table.
        SalesPriceLines.Ascending(true);                             //Sort the prices by unit price to get the lowest.
        SalesPriceLines.SetRange("Customer No.", CustomerNo);        //Set the filters for customer.
        SalesPriceLines.SetRange("Item No.", ItemNo);                //Set the filters for item.
        SalesPriceLines.SetFilter("Min. Qty", '<=%1', Quantity);     //Set the filters for quantity.
        SalesPriceLines.SetRange(Enabled, true);                     //Set the filter to find only Enabled records.
        if SalesPriceLines.FindFirst() then                          //If at least one is found, retrieve from database.
            exit(SalesPriceLines."Unit Price")                       //Then return the found Unit Price value.
        else begin
            Item.Get(ItemNo);                                        //Otherwise, retrieve the linked item.
            exit(Item."Unit Price");                                 //And return the Unit Price value of this item.
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