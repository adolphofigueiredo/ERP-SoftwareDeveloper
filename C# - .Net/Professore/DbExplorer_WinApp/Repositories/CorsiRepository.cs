using System;
using System.Collections.Generic;
using System.Linq;
using DbExplorer_WinApp.Models;
using DbExplorer_WinApp.Models.Entities;
using DbExplorer_WinApp.Models.Filters;

namespace DbExplorer_WinApp.Repositories
{
    public class CorsiRepository
    {
        public ICollection<CorsoEntity> Find(CorsoFilter filter)
        {
            using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
            {
                IQueryable<CorsoEntity> query = ApplyFilter(ctx, filter);

                return query.ToList(); // SELECT * FROM AnagreaficheStudenti WHERE  nome or cognome contains filter ....
            }
        }
        public int Count(CorsoFilter filter)
        {
            using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
            {
                IQueryable<CorsoEntity> query = ApplyFilter(ctx, filter);

                return query.Count();
            }
        }
        private IQueryable<CorsoEntity> ApplyFilter(ItsCorsiEsamiContext ctx, CorsoFilter filter)
        {
            IQueryable<CorsoEntity> query = ctx.Corsi;

            if (!string.IsNullOrEmpty(filter.Nome))
                query = query.Where(r => r.Nome.Contains(filter.Nome));

            if (filter.Da.HasValue && filter.A.HasValue)
            {
                query = query.Where(db => filter.A.Value >= db.DataValiditaInizio &&
                    filter.Da.Value <= db.DataValiditaFine);
            }
            else if (filter.Da.HasValue)
                query = query.Where(db => db.DataValiditaInizio <= filter.Da.Value);
            else if (filter.A.HasValue)
                query = query.Where(db => db.DataValiditaFine >= filter.A.Value);

            return query;
        }

        public CorsoEntity Get(int id)
        {
            using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
            {
                return ctx.Corsi.FirstOrDefault(r => r.Id == id);
            }
        }

        public CorsoEntity Post(CorsoEntity input)
        {
            using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
            {
                // salvo i dati
                ctx.Corsi.Add(input);
                ctx.SaveChanges();
            }

            return input;
        }

        public CorsoEntity Put(int id, CorsoEntity input)
        {
            using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
            {
                var dbValue = ctx.Corsi.FirstOrDefault(r => r.Id == id);
                if (dbValue == null) throw new ArgumentException($"Nessun dato trovato con id:{id}");

                // salvo i dati
                dbValue.Nome = input.Nome;
                dbValue.DataValiditaFine = input.DataValiditaFine;
                dbValue.DataValiditaInizio = input.DataValiditaInizio;

                ctx.SaveChanges();
                return dbValue;
            }
        }

        public CorsoEntity Delete(int id)
        {
            using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
            {
                var dbValue = ctx.Corsi.FirstOrDefault(r => r.Id == id);
                if (dbValue == null) throw new ArgumentException($"Nessun dato trovato con id:{id}");

                // salvo i dati
                ctx.Corsi.Remove(dbValue);
                ctx.SaveChanges();
                return dbValue;
            }
        }
    }
}
