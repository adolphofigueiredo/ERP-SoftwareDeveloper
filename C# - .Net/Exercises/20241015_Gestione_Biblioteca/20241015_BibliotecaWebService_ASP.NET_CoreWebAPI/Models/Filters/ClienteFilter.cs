namespace _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Filters
{
    public class ClienteFilter                        //Classe criada para fornecer critérios que podem ser usados para
                                                      //filtrar clientes ao consultar o banco de dados.
    {
        public string CodiceFiscale { get; set; }     //Critério de busca pelo código fiscal do cliente. Provavelmente
                                                      //será usado em pesquisas para encontrar um cliente específico com
                                                      //base nesse identificador único.
        public string Nominativo { get; set; }        //Refere-se a uma combinação de nome e sobrenome do cliente. Esse
                                                      //filtro pode ser usado para buscar clientes que correspondem parcial
                                                      //ou totalmente ao nome inserido.
    }
}