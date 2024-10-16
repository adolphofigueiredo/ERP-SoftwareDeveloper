namespace _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Dtos
{
    public class ClienteDto                           //O objetivo dessa classe é encapsular e transportar apenas as
                                                      //informações necessárias de um cliente entre diferentes camadas
                                                      //da aplicação. Como é um DTO, ela é usada para simplificar a
                                                      //transferência de dados, evitando o transporte de dados
                                                      //desnecessários que podem estar presentes em uma entidade completa,
                                                      //como a ClienteEntity. Isso melhora a performance e a segurança ao
                                                      //transferir dados entre a API e outros sistemas.
    {
        public string CodiceFiscale { get; set; }     //Representa o código fiscal do cliente, que é uma espécie de CPF
                                                      //italiano. Ele serve como um identificador único para o cliente.
        public string Nome { get; set; }              //Armazena o nome do cliente.
        public string Cognome { get; set; }           //Armazena o sobrenome do cliente.
    }
}