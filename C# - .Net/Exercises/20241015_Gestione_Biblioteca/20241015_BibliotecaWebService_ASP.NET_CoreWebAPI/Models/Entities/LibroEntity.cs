
namespace _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Entities
{
    public class LibroEntity                               //Define uma entidade que representa um livro no contexto da aplicação, por exemplo,
                                                           //um livro da biblioteca.
    {
        public LibroEntity()                               //Um construtor da classe que inicializa a coleção de Prestiti como uma nova coleção
                                                           //(HashSet). O que garante que, ao criar um livro, ele já tenha uma coleção vazia de
                                                           //empréstimos pronta para uso.
        {
            Prestiti = new HashSet<PrestitoEntity>();
                                                           //HashSet<T> é uma coleção que não permite valores duplicados e oferece operações
                                                           //rápidas de busca e inserção, o que é eficiente para gerenciar relacionamentos
                                                           //muitos-para-um.
        }
        public string ISBN { get; set; }                   //Propriedade
        public string Titolo { get; set; }                 //Propriedade
        public string Autori { get; set; }                 //Propriedade
        public virtual ICollection<PrestitoEntity> Prestiti { get; set; }
                                                           //O virtual habilita o Lazy loading, o que significa que os dados relacionados, neste
                                                           //caso, os empréstimos de um livro não são carregados imediatamente quando a entidade
                                                           //livro é recuperada do banco de dados. Em vez disso, eles são carregados apenas quando
                                                           //você acessa a propriedade Prestiti pela primeira vez. O ICollection é uma interface que
                                                           //define uma coleção genérica de elementos. No contexto de uma propriedade como a que
                                                           //vimos, ela serve como um tipo que pode armazenar vários objetos de um determinado tipo.
    }
}