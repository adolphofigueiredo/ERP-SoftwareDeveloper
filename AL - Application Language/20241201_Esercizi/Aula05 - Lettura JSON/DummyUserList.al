page 50102 "Dummy User List"
{
    PageType = List;
    ApplicationArea = All;
    UsageCategory = Lists;
    SourceTable = "Dummy User";

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field(Id; Rec.Id)
                {
                    ApplicationArea = All;
                }
                field("External Id"; Rec."External Id")
                {
                    ApplicationArea = All;
                }
                field(FirstName; Rec.FirstName)
                {
                    ApplicationArea = All;
                }
                field(LastName; Rec.LastName)
                {
                    ApplicationArea = All;
                }
                field(Email; Rec.Email)
                {
                    ApplicationArea = All;
                }
                field(Phone; Rec.Phone)
                {
                    ApplicationArea = All;
                }
                field(Age; Rec.Age)
                {
                    ApplicationArea = All;
                }
            }
        }
    }

    actions
    {
        area(Processing)
        {
            action("Read User API")
            {

                trigger OnAction()
                var
                    client: HttpClient;
                    response: HttpResponseMessage;
                    content: HttpContent;
                    responseText: Text;
                    JToken: JsonToken;
                    JToken2: JsonToken;
                    JObject: JsonObject;
                    JArray: JsonArray;
                    id: Integer;
                    firstName: text;
                    lastName: text;
                    email: text;
                    phone: text;
                    age: Integer;
                    DummyUser: Record "Dummy User";

                begin
                    //contattare l'API esterna
                    client.Get('https://dummyjson.com/users', response);
                    //testare se la richiesta API è andata a buon fine
                    if not response.IsSuccessStatusCode then
                        //se non è andata a buon fine lancia un errore
                        Error(response.ReasonPhrase);
                    //se è andata a buon fine devo leggere il contenuto e scrivere dei record
                    content := response.Content;
                    content.ReadAs(responseText);
                    Message(responseText);
                    //Trasformare testo in record
                    JToken.ReadFrom(responseText);
                    JObject := JToken.AsObject();
                    JObject.Get('users', JToken);
                    JArray := JToken.AsArray();
                    foreach JToken in JArray do begin

                        JObject := JToken.AsObject();

                        //Lettura dei valori dell'oggetto

                        JObject.Get('id', JToken2);
                        id := JToken2.AsValue().AsInteger();

                        JObject.Get('firstName', JToken2);
                        firstName := JToken2.AsValue().AsText();

                        JObject.Get('lastName', JToken2);
                        lastName := JToken2.AsValue().AsText();

                        JObject.Get('email', JToken2);
                        email := JToken2.AsValue().AsText();

                        JObject.Get('phone', JToken2);
                        phone := JToken2.AsValue().AsText();

                        JObject.Get('age', JToken2);
                        age := JToken2.AsValue().AsInteger();

                        //utilizzare variabili per creare un record dummy user
                        DummyUser.Init();
                        DummyUser.Id := 0;
                        DummyUser."External Id" := id;
                        DummyUser.FirstName := firstName;
                        DummyUser.LastName := lastName;
                        DummyUser.Email := email;
                        DummyUser.Phone := phone;
                        DummyUser.Age := age;
                        DummyUser.Insert();
                    end;
                end;
            }
        }
    }
}