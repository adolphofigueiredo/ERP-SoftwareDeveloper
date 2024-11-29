pageextension 50100 ClientListExt extends "Customer List"
{
    actions
    {
        addfirst(processing) //Estou dizendo onde o botao deve ficar
        {
            action(APIButton) //Estou dizendo o nome do botao
            {
                Caption = 'Read User API'; //Estou alterando onome do botao
                ApplicationArea = All; //estou garantindo que o botao seja visivel
                Image = Calls; //Estou vinculando uma imagem ao botao

                trigger OnAction()   //Estou adicionando um trigger, gatilho, que é acionado no momento em que o botao é pressionado
                var

                    client: HttpClient;
                    response: HttpResponseMessage;
                    content: HttpContent;
                    responseTxt: Text;
                    JToken: JsonToken;

                    JArray: JsonArray;
                /*
                JToken2: JsonToken;

                JObject: JsonObject;
                Id: Integer;
                UserId: Integer;
                Title: Text;
                Body: Text;
                Post: Record Post;
                CountRecord: Integer;
                */
                begin
                    URL := 'https://jsonplaceholder.typicode.com/users'; //Estou dizendo qual é a URL que deve ser usada para se comunicar com a API
                    client.Get(URL, response); //Estou pegando as informacoes na url desejada e armazenando a resposta na variavel resposta

                    if not response.IsSuccessStatusCode() then begin //Estou testando o campo resposta para ver se tem algum erro
                        Error(response.ReasonPhrase()); //no caso de dar erro estou dizendo o motivo
                    end;

                    content := response.Content(); //Estou inserindo o conteudo da resposta em uma variavel.
                    content.ReadAs(responseTxt); //Estou transformando o valor recebido na variavel em texto.
                    Message(responseTxt); //Estou fazendo um pop up com o conteudo da resposta.

                    JToken.ReadFrom(responseTxt); //Estou transformando o texto em Token.

                    JArray := JToken.AsArray(); //Estou transformando o Token em Array.

                    /*
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
                end;*/



                end;
            }
        }
    }

    var
        URL: Text; //Criei um campo da url que pode ser usado globalmente
}