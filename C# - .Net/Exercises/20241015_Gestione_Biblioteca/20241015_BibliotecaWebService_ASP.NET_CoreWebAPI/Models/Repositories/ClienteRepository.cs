using _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Entities;
using _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Filters;
using BibliotecaWebService.Models;

namespace _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Repositories
{
    public class ClienteRepository                                   //Classe responsável por gerenciar o CRUD (Create, Read, Update,
                                                                     //Delete) e filtragem de dados para a entidade ClienteEntity.
    {
        private readonly GestioneBibliotecaContext _ctx;

        public ClienteRepository(GestioneBibliotecaContext gestioneBibliotecaContext)
        {
            _ctx = gestioneBibliotecaContext;
        }

        public ICollection<ClienteEntity> Find(ClienteFilter filter)
        {
            IQueryable<ClienteEntity> q = _ctx.Clienti;
            q = ApplyFilter(q, filter);
            return q.ToList();
        }

        public int Count(ClienteFilter filter)
        {
            IQueryable<ClienteEntity> q = _ctx.Clienti;
            q = ApplyFilter(q, filter);
            return q.Count();
        }

        private static IQueryable<ClienteEntity> ApplyFilter(IQueryable<ClienteEntity> q, ClienteFilter filter)
        {
            if (string.IsNullOrEmpty(filter.CodiceFiscale)) { q = q.Where(p => p.CodiceFiscale.Contains(filter.CodiceFiscale)); }
            if (string.IsNullOrEmpty(filter.Nominativo)) { q = q.Where(p => (p.Nome + p.Cognome).Contains(filter.Nominativo)); }

            return q;
        }

        public ClienteEntity? Get(string codiceFiscale)
        {
            return _ctx.Clienti.FirstOrDefault(r => r.CodiceFiscale == codiceFiscale);
        }

        public ClienteEntity Insert(ClienteEntity item)
        {
            _ctx.Clienti.Add(item);
            _ctx.SaveChanges();
            return item;
        }

        public ClienteEntity Update(string codiceFiscale, ClienteEntity newItem)
        {
            var itemToUpdate = _ctx.Clienti.FirstOrDefault(r => r.CodiceFiscale == codiceFiscale);
            if (itemToUpdate == null) throw new ArgumentException("CodiceFiscale non trovato");

            itemToUpdate.CodiceFiscale = newItem.CodiceFiscale;
            itemToUpdate.Nome = newItem.Nome;
            itemToUpdate.Cognome = newItem.Cognome;
            _ctx.SaveChanges();

            return itemToUpdate;
        }

        public ClienteEntity Delete(string codiceFiscale)
        {
            var itemToDelete = _ctx.Clienti.FirstOrDefault(r => r.CodiceFiscale == codiceFiscale);
            if (itemToDelete == null) throw new ArgumentException("CodiceFiscale non trovato");

            _ctx.Clienti.Remove(itemToDelete);
            _ctx.SaveChanges();

            return itemToDelete;
        }
    }
}
