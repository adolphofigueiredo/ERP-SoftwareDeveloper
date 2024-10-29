using _20241024_GestioneMagazzino.Models;
using _20241024_GestioneMagazzino.Models.Dto;
using _20241024_GestioneMagazzino.Models.Entities;
using _20241024_GestioneMagazzino.Models.Filters;
using Microsoft.AspNetCore.Mvc;

namespace _20241024_GestioneMagazzino.Repositories
{
    public class FornitoreRepository
    {
        private readonly GestioneMagazzinoContext _ctx;

        public FornitoreRepository(GestioneMagazzinoContext ctx)
        {
            _ctx = ctx;
        }

        public ICollection<FornitoreEntity> Find(FornitoreFilter filter)
        {
            IQueryable<FornitoreEntity> query = ApplyFilter(_ctx, filter);

            return query.ToList();
        }

        public int Count(FornitoreFilter filter)
        {
            IQueryable<FornitoreEntity> query = ApplyFilter(_ctx, filter);

            return query.Count();
        }

        private IQueryable<FornitoreEntity> ApplyFilter(GestioneMagazzinoContext ctx, FornitoreFilter filter)
        {
            IQueryable<FornitoreEntity> query = ctx.Fornitori;

            if (!string.IsNullOrEmpty(filter.Nome))
                query = query.Where(r => r.Nome.Contains(filter.Nome));

            return query;
        }

        public FornitoreEntity Get(int id)
        {
            return _ctx.Fornitori.FirstOrDefault(r => r.Id == id);

        }

        public FornitoreEntity Post(FornitoreEntity input)
        {
            _ctx.Fornitori.Add(input);
            _ctx.SaveChanges();
            return input;
        }

        public FornitoreEntity Put(int id, FornitoreEntity input)
        {
            var dbValue = _ctx.Fornitori.FirstOrDefault(r => r.Id == id);

            if (dbValue != null) throw new ArgumentException($"Nessun dato trovato con id:{id}");

            dbValue.Nome = input.Nome;

            _ctx.SaveChanges();
            return dbValue;
        }

        public FornitoreEntity Delete(int id)
        {
            var dbValue = _ctx.Fornitori.FirstOrDefault(r => r.Id == id);

            if (dbValue != null) throw new ArgumentException($"Nessun dato trovato con id:{id}");

            _ctx.Fornitori.Remove(dbValue);

            _ctx.SaveChanges();
            return dbValue;
        }
    }
}