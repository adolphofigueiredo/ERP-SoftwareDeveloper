namespace _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Dtos
{
    public class LibroDto                        //O objetivo dessa classe é encapsular e transportar apenas as
                                                 //informações necessárias de um livro entre diferentes camadas
                                                 //da aplicação. Como é um DTO, ela é usada para simplificar a
                                                 //transferência de dados, evitando o transporte de dados
                                                 //desnecessários que podem estar presentes em uma entidade completa,
                                                 //como a LibroEntity. Isso melhora a performance e a segurança ao
                                                 //transferir dados entre a API e outros sistemas.
    {
        public string ISBN { get; set; }         //Armazena o idetificador único do livro (International Standard
                                                 //Book Number), que é usado globalmente para identificar livros.
        public string Titolo { get; set; }       //Armazena o título do livro.
        public string Autori { get; set; }       //Armazena os nomes dos autores do livro.
    }
}
