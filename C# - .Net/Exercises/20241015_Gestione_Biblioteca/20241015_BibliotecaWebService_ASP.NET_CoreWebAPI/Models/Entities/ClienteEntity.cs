
namespace _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Entities
{
    public class ClienteEntity                             //Define uma entidade que representa um cliente no contexto da aplicação, por exemplo,
                                                           //um cliente de uma biblioteca.
    {
        public ClienteEntity()                             //Um construtor da classe que inicializa a coleção de Prestiti como uma nova coleção
                                                           //(HashSet). O que garante que, ao criar um novo cliente, ele já tenha um espaço para
                                                           //armazenar empréstimos de livros (mesmo que inicialmente vazia).
        {
            Prestiti = new HashSet<PrestitoEntity>(); 
                                                           //HashSet<T> é uma coleção que não permite valores duplicados e oferece operações
                                                           //rápidas de busca e inserção, o que é eficiente para gerenciar relacionamentos
                                                           //muitos-para-um.
        }
        public string CodiceFiscale { get; set; }          //Propriedade
        public string Nome { get; set; }                   //Propriedade
        public string Cognome { get; set; }                //Propriedade
        public virtual ICollection<PrestitoEntity> Prestiti { get; set; }
                                                           //O virtual habilita o Lazy loading, o que significa que os dados relacionados, neste
                                                           //caso, os empréstimos de um cliente não são carregados imediatamente quando a entidade
                                                           //cliente é recuperada do banco de dados. Em vez disso, eles são carregados apenas quando
                                                           //você acessa a propriedade Prestiti pela primeira vez. O ICollection é uma interface que
                                                           //define uma coleção genérica de elementos. No contexto de uma propriedade como a que
                                                           //vimos, ela serve como um tipo que pode armazenar vários objetos de um determinado tipo.
    }
}