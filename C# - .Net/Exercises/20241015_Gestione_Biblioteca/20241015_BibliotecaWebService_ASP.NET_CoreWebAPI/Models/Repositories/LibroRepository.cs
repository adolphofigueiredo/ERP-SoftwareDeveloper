using _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Entities;
using _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Filters;
using BibliotecaWebService.Models;

namespace _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Repositories
{
    public class LibroRepository                                     //Classe responsável por gerenciar o CRUD (Create, Read, Update,
                                                                     //Delete) e filtragem de dados para a entidade LibroEntity.
    {
        private readonly GestioneBibliotecaContext _ctx;             //_ctx é uma variável privada e só de leitura que armazena o contexto
                                                                     //do banco de dados (classe GestioneBibliotecaContext). Esse contexto
                                                                     //é usado para interagir com o banco de dados através do Entity Framework.
        public LibroRepository(GestioneBibliotecaContext gestioneBibliotecaContext)
        {                                                            //Este construtor da classe recebe um objeto GestioneBibliotecaContext e
                                                                     //o atribui à variável _ctx. Isso garante que todas as operações de banco
                                                                     //de dados neste repositório possam usar o mesmo contexto.
            _ctx = gestioneBibliotecaContext;
        }

        public ICollection<LibroEntity> Find(LibroFilter filter)     //O método Find faz uma busca filtrada de livros com base nos critérios
                                                                     //fornecidos na classe LibroFilter.
        {
            IQueryable<LibroEntity> q = _ctx.Libri;     
            q = ApplyFilter(q, filter);
            return q.ToList();                                       //O _ctx.Libri é o contexto que obtém todos os livros no banco de dados.
                                                                     //O método ApplyFilter é chamado para aplicar os filtros de busca.O método
                                                                     //retorna uma lista de LibroEntity que correspondem ao filtro aplicado.
        }
        public int Count(LibroFilter filter)                         //O método Count retorna o número de livros que correspondem aos critérios de filtragem no LibroFilter.
        {
            IQueryable<LibroEntity> q = _ctx.Libri;
            q = ApplyFilter(q, filter);
            return q.Count();                                        //Segue uma lógica semelhante ao método Find, mas em vez de retornar a
                                                                     //lista de resultados, ele conta quantos itens correspondem ao filtro.
        }
        private static IQueryable<LibroEntity> ApplyFilter(IQueryable<LibroEntity> q, LibroFilter filter) //Este método aplica os filtros de busca abaixo.
        {
            if (string.IsNullOrEmpty(filter.Titolo)) { q = q.Where(p => p.Titolo.Contains(filter.Titolo)); }
            if (string.IsNullOrEmpty(filter.ISBN)) { q = q.Where(p => p.ISBN.Contains(filter.ISBN)); }
            if (string.IsNullOrEmpty(filter.Autori)) { q = q.Where(p => p.Autori.Contains(filter.Autori)); }
                                                                     //Verifica se o parametro especificado para cada filtro está ou não vazio.
                                                                     //Se não estiver, adiciona a condição de filtragem para encontrar os livros
                                                                     //no banco de dados e retorna a consulta filtrada.
            return q;
        }
        public LibroEntity? Get(string ISBN)                         //Este método Get retorna um livro específico com base no seu ISBN.
        {
            return _ctx.Libri.FirstOrDefault(r => r.ISBN == ISBN);   //Usa o método FirstOrDefault para encontrar o primeiro livro que tenha o ISBN
                                                                     //informado e retorna o livro ou null se nenhum livro for encontrado com aquele ISBN.
        }
        public LibroEntity Insert(LibroEntity item)                  //Este método Insert insere um novo livro no banco de dados.
        {
            _ctx.Libri.Add(item);
            _ctx.SaveChanges();
            return item;                                             //O livro é adicionado no contexto do banco e, em seguida, chama SaveChanges para
                                                                     //salvar a alteração realizada e depois chama Item para mostrar o que foi feito.
        }
        public LibroEntity? Update(string ISBN, LibroEntity newItem) //Este método Update atualiza os dados de um livro existente no banco.
        {
            var itemToUpdate = _ctx.Libri.FirstOrDefault(r => r.ISBN == ISBN);
                                                                     //Usa o método FirstOrDefault para encontrar o primeiro livro que tenha o ISBN
                                                                     //informado e retorna o livro ou null se nenhum livro for encontrado com aquele ISBN.
            if (itemToUpdate == null) throw new ArgumentException("ISBN non trovato");
                                                                     //Exceção lançada no caso do livro não ser encontrado.
            itemToUpdate.ISBN = newItem.ISBN;
            itemToUpdate.Titolo = newItem.Titolo;
            itemToUpdate.Autori = newItem.Autori;
            _ctx.SaveChanges();                                      //Atualiza as propriedades (ISBN, Titolo, Autori) com os novos valores do newItem e
                                                                     //após a atualização, salva as mudanças no banco com SaveChanges.
            return itemToUpdate;                                     //Retorna o item alterado para que seja visto o que foi feito.
        }
        public LibroEntity? Delete(string ISBN)                      //Este método Delete exclui um livro com base no ISBN fornecido.
        {
            var itemToDelete = _ctx.Libri.FirstOrDefault(r => r.ISBN == ISBN);
                                                                     //Usa o método FirstOrDefault para encontrar o primeiro livro que tenha o ISBN
                                                                     //informado e retorna o livro ou null se nenhum livro for encontrado com aquele ISBN.
            if (itemToDelete == null) throw new ArgumentException("ISBN non trovato");
                                                                     //Exceção lançada no caso do livro não ser encontrado.
            _ctx.Libri.Remove(itemToDelete);                         //Acesso a tabela livro, através do contexto, e remoçao do item encontrado acima.
            _ctx.SaveChanges();                                      //Contexto usado para acessar o banco de dados e salvar as alteraçoes realizadas.

            return itemToDelete;                                     //Retorna o item alterado para que seja visto o que foi feito.
        }
    }
}