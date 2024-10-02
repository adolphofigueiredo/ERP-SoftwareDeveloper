using _20240918_Database_FrameWork.Models.Entity;
using _20240918_Database_FrameWork.Models.Filters;
using _20240918_Database_FrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240918_Database_FrameWork.Repositories
{
    public class CorsoRepository
    {

        public ICollection<CorsoEntity> Find(CorsoFilter filter)
        {
            using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
            {
                IQueryable<CorsoEntity> query = ApplyFilter(ctx, filter);

                return query.ToList();                                                             // SELECT * FROM AnagreaficheCorsi WHERE  Nome contains 'filter'
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

            if (!string.IsNullOrEmpty(filter.NominativoCorso))
                query = query.Where(r => r.Nome.Contains(filter.NominativoCorso));

            if (filter.InizioCorsoDa.HasValue)
                query = query.Where(r => r.DataValiditaInizio >= filter.InizioCorsoDa);

            if(filter.InizioCorsoA.HasValue)
                query = query.Where(s => s.DataValiditaInizio <= filter.InizioCorsoA);

            if (filter.FineCorsoDa.HasValue)
                query = query.Where(t => t.DataValiditaFine >= filter.FineCorsoDa);

            if (filter.FineCorsoA.HasValue)
                query = query.Where(u => u.DataValiditaFine <= filter.FineCorsoA);
            
            return query;
        }

        public CorsoEntity? Get(int id)
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
                if (dbValue == null) throw new ArgumentException($"No data found with ID:{id}");

                // salvo i dati
                dbValue.Nome = input.Nome;
                dbValue.DataValiditaInizio = input.DataValiditaInizio;
                dbValue.DataValiditaFine = input.DataValiditaFine;
                ctx.SaveChanges();
                return dbValue;
            }
        }

        public CorsoEntity Delete(int id)
        {
            using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
            {
                var dbValue = ctx.Corsi.FirstOrDefault(r => r.Id == id);
                if (dbValue == null) throw new ArgumentException($"No data found with ID:{id}");

                // salvo i dati
                ctx.Corsi.Remove(dbValue);
                ctx.SaveChanges();
                return dbValue;
            }
        }
    }
}