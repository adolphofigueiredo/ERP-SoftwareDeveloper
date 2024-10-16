using _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Entities;
using _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Filters;
using BibliotecaWebService.Models;

namespace _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Repositories
{
    public class LibroRepository                                     //Classe responsável por gerenciar o CRUD (Create, Read, Update,
                                                                     //Delete) e filtragem de dados para a entidade LibroEntity.
    {
        private readonly GestioneBibliotecaContext _ctx;

        public LibroRepository(GestioneBibliotecaContext gestioneBibliotecaContext)
        {
            _ctx = gestioneBibliotecaContext;
        }

        public ICollection<LibroEntity> Find(LibroFilter filter)
        {
            IQueryable<LibroEntity> q = _ctx.Libri;
            q = ApplyFilter(q, filter);
            return q.ToList();
        }

        public int Count(LibroFilter filter)
        {
            IQueryable<LibroEntity> q = _ctx.Libri;
            q = ApplyFilter(q, filter);
            return q.Count();
        }

        private static IQueryable<LibroEntity> ApplyFilter(IQueryable<LibroEntity> q, LibroFilter filter)
        {
            if (string.IsNullOrEmpty(filter.Titolo)) { q = q.Where(p => p.Titolo.Contains(filter.Titolo)); }
            if (string.IsNullOrEmpty(filter.ISBN)) { q = q.Where(p => p.ISBN.Contains(filter.ISBN)); }
            if (string.IsNullOrEmpty(filter.Autori)) { q = q.Where(p => p.Autori.Contains(filter.Autori)); }

            return q;
        }

        public LibroEntity? Get(string ISBN)
        {
            return _ctx.Libri.FirstOrDefault(r => r.ISBN == ISBN);
        }

        public LibroEntity Insert(LibroEntity item)
        {
            _ctx.Libri.Add(item);
            _ctx.SaveChanges();
            return item;
        }

        public LibroEntity? Update(string ISBN, LibroEntity newItem)
        {
            var itemToUpdate = _ctx.Libri.FirstOrDefault(r => r.ISBN == ISBN);
            if (itemToUpdate == null) throw new ArgumentException("ISBN non trovato");

            itemToUpdate.ISBN = newItem.ISBN;
            itemToUpdate.Titolo = newItem.Titolo;
            itemToUpdate.Autori = newItem.Autori;
            _ctx.SaveChanges();

            return itemToUpdate;
        }

        public LibroEntity? Delete(string ISBN)
        {
            var itemToDelete = _ctx.Libri.FirstOrDefault(r => r.ISBN == ISBN);
            if (itemToDelete == null) throw new ArgumentException("ISBN non trovato");

            _ctx.Libri.Remove(itemToDelete);
            _ctx.SaveChanges();

            return itemToDelete;
        }
    }
}
