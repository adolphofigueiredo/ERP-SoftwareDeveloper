using _20241024_GestioneMagazzino.Models;
using _20241024_GestioneMagazzino.Models.Dto;
using _20241024_GestioneMagazzino.Models.Entities;
using _20241024_GestioneMagazzino.Models.Filters;
using Microsoft.AspNetCore.Mvc;

namespace _20241024_GestioneMagazzino.Repositories
{
    public class ClienteRepository
    {
        private readonly GestioneMagazzinoContext _ctx;

        public ClienteRepository(GestioneMagazzinoContext ctx)
        {
            _ctx = ctx;
        }

        public ICollection<ClienteEntity> Find(ClienteFilter filter)
        { 
            IQueryable<ClienteEntity> query = ApplyFilter(_ctx, filter);

            return query.ToList();
        }

        public int Count(ClienteFilter filter)
        {
            IQueryable<ClienteEntity> query = ApplyFilter(_ctx, filter);
            
            return query.Count();
        }

        private IQueryable<ClienteEntity> ApplyFilter(GestioneMagazzinoContext ctx, ClienteFilter filter)
        {
            IQueryable<ClienteEntity> query = ctx.Clienti;

            if(!string.IsNullOrEmpty(filter.Nome))
                query = query.Where(r => r.Nome.Contains(filter.Nome));

            return query;
        }

        public ClienteEntity Get(int id)
        {
            return _ctx.Clienti.FirstOrDefault(r => r.Id == id);
        
        }

        public ClienteEntity Post(ClienteEntity input)
        {
            _ctx.Clienti.Add(input);
            _ctx.SaveChanges();
            return input;
        }

        public ClienteEntity Put(int id, ClienteEntity input)
        {
            var dbValue = _ctx.Clienti.FirstOrDefault(r =>r.Id == id);

            if (dbValue != null) throw new ArgumentException($"Nessun dato trovato con id:{id}");

            dbValue.Nome = input.Nome;

            _ctx.SaveChanges();
            return dbValue;
        }

        public ClienteEntity Delete(int id)
        {
            var dbValue = _ctx.Clienti.FirstOrDefault(r => r.Id == id);

            if (dbValue != null) throw new ArgumentException($"Nessun dato trovato con id:{id}");

            _ctx.Clienti.Remove(dbValue);

            _ctx.SaveChanges();
            return dbValue;
        }
    }
}