pageextension 50109 ItemListPageExt extends "Item List"
{
    layout
    {
        // Add changes to page layout here
    }

    actions
    {
        addfirst(processing)
        {
            action(ReadProductsAPI)
            {
                Caption = 'Read Products API';
                ApplicationArea = All;
                Image = Calls;

                trigger OnAction()
                var
                    client: HttpClient;
                    response: HttpResponseMessage;
                    content: HttpContent;
                    responseText: Text;
                    item: Record Item;
                    JToken: JsonToken;
                    JObject: JsonObject;
                    JToken2: JsonToken;
                    JArray: JsonArray;
                    id: Integer;
                    name: Text;
                    price: Decimal;
                /*firstName: text;
                lastName: text;
                email: text;
                phone: text;
                age: Integer;
                DummyUser: Record "Dummy User";*/
                begin
                    client.Get('https://fakerapi.it/api/v1/products?_quantity=10', response);
                    if not response.IsSuccessStatusCode then
                        Error(response.ReasonPhrase);

                    content := response.Content;
                    content.ReadAs(responseText);
                    Message(responseText);
                    JToken.ReadFrom(responseText);
                    JObject := JToken.AsObject();
                    JObject.Get('data', JToken);
                    JObject := JToken.AsObject();


                    foreach JToken2 in JArray do begin

                        JObject.Get('name', Jtoken);
                        name := JToken2.AsValue().AsText();
                        JObject.Get('price', Jtoken2);
                        price := JToken.AsValue().AsDecimal();
                        item.Init();
                        item."No." := '';
                        item."Unit Price" := price;
                        item."Base Unit of Measure" := 'PZ';
                    end;
                end;
            }
        }
    }
}

/*

3) Utilizzo delle API esterne:

    5. Convertire la risposta dal formato testo in un JSON (analizzate la risposta per capire quali variabili utilizzare)
    6. Creare un record Item per ogni prodotto trovato nella risposta, utilizzare i seguenti campi:
        name -> Item.Name
        price -> Item."Unit Price"
        Utilizzare il valore 'PZ' per il campo Item."Base Unit of Measure"
        Tutti e tre i valori vanno inseriti con un Validate e l'inserimento deve scatenare il relativo trigger.

        */
