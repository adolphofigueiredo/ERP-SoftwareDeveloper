page 50110 "API Demo"
{
    PageType = Card;
    ApplicationArea = All;
    UsageCategory = Tasks;

    layout
    {
        area(Content)
        {
            group(GroupName)
            {
                field(URL; URL)
                {
                    ApplicationArea = All;
                }
                field(StatusCode; StatusCode)
                {
                    ApplicationArea = All;
                    Editable = false;
                }
            }
        }
    }

    actions
    {
        area(Processing)
        {
            action(CallAPI)
            {
                Image = Export1099;
                ApplicationArea = All;
                Caption = 'Call API';
                trigger OnAction()
                var
                    client: HttpClient;
                    response: HttpResponseMessage;
                    content: HttpContent;
                    responseTxt: Text;
                    JToken: JsonToken;
                    JToken2: JsonToken;
                    JArray: JsonArray;
                    JObject: JsonObject;
                    Id: Integer;
                    UserId: Integer;
                    Title: Text;
                    Body: Text;
                    Post: Record Post;
                    CountRecord: Integer;
                begin
                    // eseguo una GET sull'url indicato
                    client.Get(URL, response);
                    // salvo lo status code in una variabile
                    StatusCode := response.HttpStatusCode();
                    // controllo se la richiesta è andata a buon fine
                    if not response.IsSuccessStatusCode() then begin
                        // lancio un errore con il motivo dell'errore
                        Error(response.ReasonPhrase());
                    end;
                    // Success della risposta
                    // prendo il content dalla risposta
                    content := response.Content();
                    // leggo il testo dal content
                    content.ReadAs(responseTxt);
                    // stampo la risposta in formato testo
                    // Message(responseTxt);

                    // Trasformo il testo in Token
                    JToken.ReadFrom(responseTxt);
                    // Trasformo il Token in array
                    JArray := JToken.AsArray();
                    // ciclo l'array
                    foreach JToken2 in JArray do begin
                        // conversione di JToken2 in JObject
                        JObject := JToken2.AsObject();
                        // Preso il valore relativo alla chiave 'id'
                        JObject.Get('id', JToken);
                        // ho convertito il token in valore intero
                        Id := JToken.AsValue().AsInteger();
                        // conversione degli altri valori dell'oggetto
                        JObject.Get('userId', JToken);
                        UserId := JToken.AsValue().AsInteger();
                        JObject.Get('title', JToken);
                        Title := JToken.AsValue().AsText();
                        JObject.Get('body', JToken);
                        Body := JToken.AsValue().AsText();

                        // scrivere un record con i valori presi dall'oggetto JSON
                        Post.Id := 0;
                        Post."External Id" := Id;
                        Post."User Id" := UserId;
                        Post.Title := Title;
                        Post.Body := Body;
                        Post.Insert();
                        CountRecord += 1;
                    end;
                    Message('Record Inseriti %1', CountRecord);
                end;
            }
        }
    }

    var
        StatusCode: Integer;
        URL: Text;
}