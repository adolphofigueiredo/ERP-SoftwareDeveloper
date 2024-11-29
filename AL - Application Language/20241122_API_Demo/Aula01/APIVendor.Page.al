page 50130 "API Vendor"
{
    //Primeiro se deve entrar em um browser e colar este link: http://bcserver:7048/BC/api/v2.0/companies?tenant=default
    //Isso possibilita que vc acesse as credenciais necessarias para montar o link da API.

    // <base URL>/api/<API publisher>/<API group>/<API version>/<entitysetname>
    // http://bcserver:7048/BC/api/its/demo/v1.0/companies(86d89be1-369f-ef11-8a6d-6045bde9ba24)/vendors?tenant=default
    //?tenant=default este pedaco foi adicionado por causa de um erro de autorizacao que dava por acessarmos de uma maquina virtual.

    PageType = API;
    Caption = 'apiPageName';
    APIPublisher = 'ITS';         //A empresa que faz este API
    APIGroup = 'demo';            //Pode ser dividido em grupos como, vendas, produçao, power apps. Pode ser usado para organizar melhor as APIs.
    APIVersion = 'v1.0';          //Nao se atualiza arquivos de API, a gente cria uma nova, pois mudar uma API pode estragar todos os serviços que ainda nao foram atualizados.        
    EntityName = 'vendor';
    EntitySetName = 'vendors';
    SourceTable = Vendor;
    DelayedInsert = true;

    layout
    {
        area(Content)
        {
            repeater(GroupName)
            {
                field("No"; Rec."No.") //Repare que no "No." eu tirei o ponto, pois isso causa um erro no postaman.
                                       //O campo rec mantém pois ele é a referencia.
                                       //Pontos e espaços podem causa problemas.
                { }
                field(Name; Rec.Name) { }
                field("Phone_No"; Rec."Phone No.") { }
                field("Email"; Rec."E-mail") { }
                field("Home_Page"; Rec."Home Page") { }
                field("Language_Code"; Rec."Language Code") { }
                field(language; LangName) { } // Este campo nao esta ligado a tabela, ele é um campo que so e usado na leitura atraves do trigger OnAfterGetCurrRecord.
            }
        }
    }
    var
        LangName: Text;

    trigger OnAfterGetCurrRecord()
    var
        Language: Record Language;
    begin
        if Language.Get(Rec."Language Code") then
            LangName := Language.Name
        else
            LangName := '';
    end;
}