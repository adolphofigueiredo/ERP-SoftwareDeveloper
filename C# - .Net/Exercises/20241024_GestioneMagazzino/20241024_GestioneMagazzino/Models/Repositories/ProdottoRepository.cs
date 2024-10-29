using _20241024_GestioneMagazzino.Models;
using _20241024_GestioneMagazzino.Models.Dto;
using _20241024_GestioneMagazzino.Models.Entities;
using _20241024_GestioneMagazzino.Models.Filters;
using Microsoft.AspNetCore.Mvc;

namespace _20241024_GestioneMagazzino.Repositories
{
    public class ProdottoRepository
    {
        private readonly GestioneMagazzinoContext _ctx;

        public ProdottoRepository(GestioneMagazzinoContext ctx)
        {
            _ctx = ctx;
        }

        public ICollection<ProdottoEntity> Find(ProdottoFilter filter)
        {
            IQueryable<ProdottoEntity> query = ApplyFilter(_ctx, filter);

            return query.ToList();
        }

        public int Count(ProdottoFilter filter)
        {
            IQueryable<ProdottoEntity> query = ApplyFilter(_ctx, filter);

            return query.Count();
        }

        private IQueryable<ProdottoEntity> ApplyFilter(GestioneMagazzinoContext ctx, ProdottoFilter filter)
        {
            IQueryable<ProdottoEntity> query = ctx.Prodotti;

            if (!string.IsNullOrEmpty(filter.Descrizione))
                query = query.Where(r => r.Descrizione.Contains(filter.Descrizione));

            return query;
        }

        public ProdottoEntity Get(int id)
        {
            return _ctx.Prodotti.FirstOrDefault(r => r.Id == id);

        }

        public ProdottoEntity Post(ProdottoEntity input)
        {
            _ctx.Prodotti.Add(input);
            _ctx.SaveChanges();
            return input;
        }

        public ProdottoEntity Put(int id, ProdottoEntity input)
        {
            var dbValue = _ctx.Prodotti.FirstOrDefault(r => r.Id == id);

            if (dbValue != null) throw new ArgumentException($"Nessun dato trovato con id:{id}");

            dbValue.Descrizione = input.Descrizione;

            _ctx.SaveChanges();
            return dbValue;
        }

        public ProdottoEntity Delete(int id)
        {
            var dbValue = _ctx.Prodotti.FirstOrDefault(r => r.Id == id);

            if (dbValue != null) throw new ArgumentException($"Nessun dato trovato con id:{id}");

            _ctx.Prodotti.Remove(dbValue);

            _ctx.SaveChanges();
            return dbValue;
        }
    }
}