using _20241024_GestioneMagazzino.Models;
using _20241024_GestioneMagazzino.Models.Dto;
using _20241024_GestioneMagazzino.Models.Entities;
using _20241024_GestioneMagazzino.Models.Filters;
using Microsoft.EntityFrameworkCore;

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
            var query = ApplyFilter(filter);
            return query.Include(p => p.OrdineClienteDettagli)
                        .Include(p => p.OrdineFornitoreDettagli)
                        .Include(p => p.MovimentiMagazzino)
                        .ToList();
        }

        public int Count(ProdottoFilter filter)
        {
            var query = ApplyFilter(filter);
            return query.Count();
        }

        private IQueryable<ProdottoEntity> ApplyFilter(ProdottoFilter filter)
        {
            var query = _ctx.Prodotti.AsQueryable();

            if (!string.IsNullOrEmpty(filter.Descrizione))
                query = query.Where(r => r.Descrizione.Contains(filter.Descrizione));

            if (filter.Altezza > 0)
                query = query.Where(r => r.Altezza == filter.Altezza);

            if (filter.Larghezza > 0)
                query = query.Where(r => r.Larghezza == filter.Larghezza);

            if (filter.Profondita > 0)
                query = query.Where(r => r.Profondita == filter.Profondita);

            if (filter.Peso > 0)
                query = query.Where(r => r.Peso == filter.Peso);

            return query;
        }

        public ProdottoEntity Get(int id)
        {
            return _ctx.Prodotti
                       .Include(p => p.OrdineClienteDettagli)
                       .Include(p => p.OrdineFornitoreDettagli)
                       .Include(p => p.MovimentiMagazzino)
                       .FirstOrDefault(r => r.Id == id);
        }

        public ProdottoEntity Update(ProdottoEntity input)
        {
            _ctx.Prodotti.Update(input);
            _ctx.SaveChanges();
            return input;
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

            if (dbValue == null)
                throw new ArgumentException($"No data found with id: {id}");

            if (input.Descrizione != null)
            {
                dbValue.Descrizione = input.Descrizione;
            }

            if (input.Altezza > 0)
            {
                dbValue.Altezza = input.Altezza;
            }

            if (input.Larghezza > 0)
            {
                dbValue.Larghezza = input.Larghezza;
            }

            if (input.Profondita > 0)
            {
                dbValue.Profondita = input.Profondita;
            }

            if (input.Peso > 0)
            {
                dbValue.Peso = input.Peso;
            }

            _ctx.SaveChanges();
            return dbValue;
        }

        public ProdottoEntity Delete(int id)
        {
            var dbValue = _ctx.Prodotti.FirstOrDefault(r => r.Id == id);

            if (dbValue == null)
                throw new ArgumentException($"No data found with id: {id}");

            _ctx.Prodotti.Remove(dbValue);
            _ctx.SaveChanges();
            return dbValue;
        }
    }
}
