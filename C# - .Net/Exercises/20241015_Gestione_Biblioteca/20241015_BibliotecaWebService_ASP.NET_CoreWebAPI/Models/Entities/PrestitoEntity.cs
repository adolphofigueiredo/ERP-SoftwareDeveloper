namespace _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Entities
{
    public class PrestitoEntity                            //Define a classe PrestitoEntity, que representa um "empréstimo" no sistema. Uma entidade
                                                           //é usada para mapear informações no banco de dados e aqui essa classe vai armazenar dados
                                                           //de empréstimos de livros para clientes.
    {
        public DateTime DataInizio { get; set; }           //Propriedade
        public DateTime? DataFine { get; set; }            //Propriedade
        public string ISBN { get; set; }                   //Propriedade
        public virtual LibroEntity Libro { get; set; }     //O virtual habilita o Lazy loading, o que significa que os dados relacionados, neste
                                                           //caso, os empréstimos de um cliente não são carregados imediatamente quando a entidade
                                                           //cliente é recuperada do banco de dados.
        public string CodiceFiscale { get; set; }          //Propriedade
        public virtual ClienteEntity Cliente { get; set; } //O virtual habilita o Lazy loading, o que significa que os dados relacionados, neste
                                                           //caso, os empréstimos de um cliente não são carregados imediatamente quando a entidade
                                                           //cliente é recuperada do banco de dados.
    }
}
