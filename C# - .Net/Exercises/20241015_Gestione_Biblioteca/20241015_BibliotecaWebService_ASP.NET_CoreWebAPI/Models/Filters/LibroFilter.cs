namespace _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Filters
{
    public class LibroFilter                     //A classe foi criada para fornecer critérios de pesquisa que podem
                                                 //ser usados ao consultar o banco de dados de livros.
    {
        public string ISBN { get; set; }         //Critério de busca baseado no código ISBN do livro, é um identificador
                                                 //único que ajuda a encontrar um livro específico.
        public string Titolo { get; set; }       //Critério que permite buscar livros com base em seu título, isso pode
                                                 //ser usado para realizar buscas por livros que tenham um título
                                                 //específico ou parcial.
        public string Autori { get; set; }       //Critério que se refere aos autores do livro, permitindo que a consulta
                                                 //seja realizada com base nos nomes dos autores.
    }
}