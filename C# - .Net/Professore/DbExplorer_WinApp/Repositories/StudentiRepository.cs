using System;
using System.Collections.Generic;
using System.Linq;
using DbExplorer_WinApp.Models;
using DbExplorer_WinApp.Models.Entities;
using DbExplorer_WinApp.Models.Filters;

namespace DbExplorer_WinApp.Repositories
{
    public class StudentiRepository
    {
        public ICollection<StudenteEntity> Find(StudenteFilter filter)
        {
            using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
            {
                IQueryable<StudenteEntity> query = ApplyFilter(ctx, filter);

                return query.ToList(); // SELECT * FROM AnagreaficheStudenti WHERE  nome or cognome contains filter ....
            }
        }
        public int Count(StudenteFilter filter)
        {
            using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
            {
                IQueryable<StudenteEntity> query = ApplyFilter(ctx, filter);

                return query.Count();
            }
        }
        private IQueryable<StudenteEntity> ApplyFilter(ItsCorsiEsamiContext ctx, StudenteFilter filter)
        {
            IQueryable<StudenteEntity> query = ctx.Studenti;

            if (!string.IsNullOrEmpty(filter.Nominativo))
                query = query.Where(r => (r.Nome + " " + r.Cognome).Contains(filter.Nominativo));

            if (filter.Da.HasValue)
                query = query.Where(r => r.DataDiNascita >= filter.Da.Value);
            if (filter.A.HasValue)
                query = query.Where(r => r.DataDiNascita <= filter.A.Value);

            return query;
        }

        public StudenteEntity? Get(int id)
        {
            using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
            {
                return ctx.Studenti.FirstOrDefault(r => r.Id == id);
            }
        }

        public StudenteEntity Post(StudenteEntity input)
        {
            using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
            {
                // salvo i dati
                ctx.Studenti.Add(input);
                ctx.SaveChanges();
            }

            return input;
        }

        public StudenteEntity Put(int id, StudenteEntity input)
        {
            using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
            {
                var dbValue = ctx.Studenti.FirstOrDefault(r => r.Id == id);
                if (dbValue == null) throw new ArgumentException($"Nessun dato trovato con id:{id}");

                // salvo i dati
                dbValue.DataDiNascita = input.DataDiNascita;
                dbValue.Nome = input.Nome;
                dbValue.Cognome = input.Cognome;
                dbValue.CodiceFiscale = input.CodiceFiscale;
                ctx.SaveChanges();
                return dbValue;
            }
        }

        public StudenteEntity Delete(int id)
        {
            using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
            {
                var dbValue = ctx.Studenti.FirstOrDefault(r => r.Id == id);
                if (dbValue == null) throw new ArgumentException($"Nessun dato trovato con id:{id}");

                // salvo i dati
                ctx.Studenti.Remove(dbValue);
                ctx.SaveChanges();
                return dbValue;
            }
        }
    }
}
