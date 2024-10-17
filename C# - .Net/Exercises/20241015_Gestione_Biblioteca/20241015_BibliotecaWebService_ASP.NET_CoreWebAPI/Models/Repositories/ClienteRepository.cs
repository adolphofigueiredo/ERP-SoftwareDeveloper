using _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Entities;
using _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Filters;
using BibliotecaWebService.Models;

namespace _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Repositories
{
    public class ClienteRepository                                   //Classe responsável por gerenciar o CRUD (Create, Read, Update,
                                                                     //Delete) e filtragem de dados para a entidade ClienteEntity.
    {
        private readonly GestioneBibliotecaContext _ctx;             //_ctx é uma variável privada e só de leitura que armazena o contexto
                                                                     //do banco de dados (classe GestioneBibliotecaContext). Esse contexto
                                                                     //é usado para interagir com o banco de dados através do Entity Framework.
        public ClienteRepository(GestioneBibliotecaContext gestioneBibliotecaContext)
        {                                                            //Este construtor da classe recebe um objeto GestioneBibliotecaContext e
                                                                     //o atribui à variável _ctx. Isso garante que todas as operações de banco
                                                                     //de dados neste repositório possam usar o mesmo contexto.
            _ctx = gestioneBibliotecaContext;
        }
            public ICollection<ClienteEntity> Find(ClienteFilter filter)  //O método Find faz uma busca filtrada de clientes com base nos critérios
                                                                     //fornecidos na classe ClienteFilter.
        {
            IQueryable<ClienteEntity> q = _ctx.Clienti;
            q = ApplyFilter(q, filter);
            return q.ToList();                                       //O _ctx.Clienti é o contexto que obtém todos os clientes no banco de dados.
                                                                     //O método ApplyFilter é chamado para aplicar os filtros de busca.O método
                                                                     //retorna uma lista de ClienteEntity que correspondem ao filtro aplicado.
        }
        public int Count(ClienteFilter filter)                       //O método Count retorna o número de clientes que correspondem aos critérios de filtragem no ClienteFilter.
        {
            IQueryable<ClienteEntity> q = _ctx.Clienti;
            q = ApplyFilter(q, filter);
            return q.Count();                                        //Segue uma lógica semelhante ao método Find, mas em vez de retornar a
                                                                     //lista de resultados, ele conta quantos itens correspondem ao filtro.
        }
        private static IQueryable<ClienteEntity> ApplyFilter(IQueryable<ClienteEntity> q, ClienteFilter filter)
                                                                     //Este método aplica os filtros de busca abaixo.
        {
            if (string.IsNullOrEmpty(filter.CodiceFiscale)) { q = q.Where(p => p.CodiceFiscale.Contains(filter.CodiceFiscale)); }
            if (string.IsNullOrEmpty(filter.Nominativo)) { q = q.Where(p => (p.Nome + p.Cognome).Contains(filter.Nominativo)); }
                                                                     //Verifica se o parametro especificado para cada filtro está ou não vazio.
                                                                     //Se não estiver, adiciona a condição de filtragem para encontrar os clientes
                                                                     //no banco de dados e retorna a consulta filtrada.
            return q;
        }
        public ClienteEntity? Get(string codiceFiscale)              //Este método Get retorna um cliente específico com base no seu CodiceFiscale.
        {
            return _ctx.Clienti.FirstOrDefault(r => r.CodiceFiscale == codiceFiscale);
                                                                     //Usa o método FirstOrDefault para encontrar o primeiro cliente livro que tenha o CodiceFiscale
                                                                     //informado e retorna o cliente ou null se nenhum cliente for encontrado com aquele CodiceFiscale.
        }
        public ClienteEntity Insert(ClienteEntity item)              //Este método Insert insere um novo cliente no banco de dados.
        {
            _ctx.Clienti.Add(item);
            _ctx.SaveChanges();
            return item;                                             //O cliente é adicionado no contexto do banco e, em seguida, chama SaveChanges para
                                                                     //salvar a alteração realizada e depois chama Item para mostrar o que foi feito.
        }
        public ClienteEntity Update(string codiceFiscale, ClienteEntity newItem)
                                                                     //Este método Update atualiza os dados de um cliente existente no banco.        
        {
            var itemToUpdate = _ctx.Clienti.FirstOrDefault(r => r.CodiceFiscale == codiceFiscale);
                                                                     //Usa o método FirstOrDefault para encontrar o primeiro cliente que tenha o CodiceFiscale
                                                                     //informado e retorna o cliente ou null se nenhum cliente for encontrado com aquele CodiceFiscale.
            if (itemToUpdate == null) throw new ArgumentException("CodiceFiscale non trovato");
                                                                     //Exceção lançada no caso do cliente não ser encontrado.
                itemToUpdate.CodiceFiscale = newItem.CodiceFiscale;
                itemToUpdate.Nome = newItem.Nome;
                itemToUpdate.Cognome = newItem.Cognome;
                _ctx.SaveChanges();                                  //Atualiza as propriedades (CodiceFiscale, Nome, Cognome) com os novos valores do newItem e
                                                                     //após a atualização, salva as mudanças no banco com SaveChanges.
                return itemToUpdate;                                 //Retorna o item alterado para que seja visto o que foi feito.
            }
            public ClienteEntity Delete(string codiceFiscale)        //Este método Delete exclui um cliente livro com base no CodiceFiscale fornecido.
            {
                var itemToDelete = _ctx.Clienti.FirstOrDefault(r => r.CodiceFiscale == codiceFiscale);
                                                                     //Usa o método FirstOrDefault para encontrar o primeiro cliente que tenha o CodiceFiscale
                                                                     //informado e retorna o cliente ou null se nenhum cliente for encontrado com aquele CodiceFiscale.
                if (itemToDelete == null) throw new ArgumentException("CodiceFiscale non trovato");
                                                                     //Exceção lançada no caso do cliente não ser encontrado.
                _ctx.Clienti.Remove(itemToDelete);                   //Acesso a tabela livro, através do contexto, e remoçao do item encontrado acima.
                _ctx.SaveChanges();                                  //Contexto usado para acessar o banco de dados e salvar as alteraçoes realizadas.


                return itemToDelete;                                 //Retorna o item alterado para que seja visto o que foi feito.
        }
        
    }
}