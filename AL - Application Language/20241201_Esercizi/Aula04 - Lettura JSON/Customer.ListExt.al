pageextension 50100 ClientListExt extends "Customer List"
{
    actions
    {
        addfirst(processing)                          //Estou dizendo onde o botao deve ficar
        {
            action(APIButton)                         //Estou dizendo o nome do botao
            {
                Caption = 'Read User API';            //Estou alterando onome do botao
                ApplicationArea = All;                //estou garantindo que o botao seja visivel
                Image = Calls;                        //Estou vinculando uma imagem ao botao

                trigger OnAction()                    //Estou adicionando um trigger, gatilho, que é acionado no momento em que o botao é pressionado
                var

                    client: HttpClient;
                    response: HttpResponseMessage;
                    content: HttpContent;
                    responseTxt: Text;
                    JToken: JsonToken;
                    JToken2: JsonToken;
                    JArray: JsonArray;
                    JObject: JsonObject;
                    Id: Code[20];
                    Name: Text;
                    Username: Text;
                    Street: Text;
                    Suite: Text;
                    City: Text;
                    Zipcode: Text;
                    CompanyName: Text;
                    email: Text;
                    Phone: Text;
                    HomePage: Text;
                    Customer: Record Customer;
                    CountRecord: Integer;

                begin
                    URL := 'https://jsonplaceholder.typicode.com/users';                                //Estou dizendo qual é a URL que deve ser usada para se comunicar com a API

                    client.Get(URL, response);                                                          //Estou pegando as informacoes na url desejada e armazenando a resposta na variavel resposta

                    if not response.IsSuccessStatusCode() then begin                                    //Estou testando o campo resposta para ver se tem algum erro

                        Error(Format(response.HttpStatusCode) + ': ' + response.ReasonPhrase);          //no caso de dar erro estou dizendo o motivo

                    end;

                    content := response.Content();              //Estou inserindo o conteudo da resposta em uma variavel.
                    content.ReadAs(responseTxt);                //Estou transformando o valor recebido na variavel em texto.
                    Message(responseTxt);                       //Estou fazendo um pop up com o conteudo da resposta.


                    JToken.ReadFrom(responseTxt);               //Estou transformando o texto em Token.
                    JArray := JToken.AsArray();                 //Estou transformando o Token em Array.



                    foreach JToken2 in JArray do begin
                        JObject := JToken2.AsObject();          //Conversione di JToken2 in JObject

                        JObject.Get('id', JToken);              //Preso il valore relativo alla chiave 'id'
                        Id := JToken.AsValue().AsCode();        //Ho convertito il token in valore code

                        JObject.Get('name', JToken);
                        Name := JToken.AsValue().AsText();

                        JObject.Get('username', JToken);
                        Username := JToken.AsValue().AsText();

                        JObject.Get('email', JToken);
                        email := JToken.AsValue().AsText();

                        JObject.Get('phone', JToken);
                        Phone := JToken.AsValue().AsText();

                        JObject.Get('website', JToken);
                        HomePage := JToken.AsValue().AsText();


                        JObject.Get('address', JToken);
                        JObject := JToken.AsObject();

                        JObject.Get('street', JToken);
                        Street := JToken.AsValue().AsText();

                        JObject.Get('suite', JToken);
                        Suite := JToken.AsValue().AsText();

                        JObject.Get('city', JToken);
                        City := JToken.AsValue().AsText();

                        JObject.Get('zipcode', JToken);
                        Zipcode := JToken.AsValue().AsText();

                        JObject := JToken2.AsObject();                    //Conversione di JToken2 in JObject
                        JObject.Get('company', JToken);
                        JObject := JToken.AsObject();
                        JObject.Get('name', JToken);
                        CompanyName := JToken.AsValue().AsText();

                        Customer."No." := '';                             //MAIS UMA ATUALIZACAO NA HORA QUE ESTIVER INSERINDO OS CAMPOS E TIVER TRUE NO INSERT  
                        //Customer."No." := Id;                           //Scrivere un record con i valori presi dall'oggetto JSON
                        Customer.API := true;
                        Customer.Contact := Name;
                        Customer."Name 2" := Username;
                        Customer."E-Mail" := email;
                        Customer."Phone No." := Phone;
                        Customer."Home Page" := HomePage;
                        Customer.Address := Street;
                        Customer."Address 2" := Suite;
                        Customer.City := City;
                        Customer."Post Code" := Zipcode;
                        Customer.Name := CompanyName;


                        //Customer.Insert();
                        Customer.Insert(true);                            //So usar com true quando estiver com os campos obrogatorios, isso ativa a validacao de campos.

                        CountRecord += 1;
                    end;
                    Message('Record Inseriti %1', CountRecord);
                end;
            }
            action(DeleteAPITrue)
            {
                Caption = 'Cancellare i Clienti - API';                   //Estou alterando onome do botao
                ApplicationArea = All;                                    //Estou garantindo que o botao seja visivel
                Image = DeleteQtyToHandle;                                //Estou vinculando uma imagem ao botao
                trigger OnAction()
                var
                    Customer: Record Customer;
                begin
                    Customer.SetRange(API, true);
                    Customer.DeleteAll();
                end;
            }
        }
    }

    var
        URL: Text;                                                        //Criei um campo da url que pode ser usado globalmente
}