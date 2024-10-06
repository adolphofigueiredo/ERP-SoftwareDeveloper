using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models;
using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Entities;
using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Filters;

namespace _20241004_ASP.NET_CoreWebApp_ModelViewControl.Repositories
{
    public class StudentiRepository
    {
        private readonly ItsCorsiEsamiContext _ctx;
        public StudentiRepository(ItsCorsiEsamiContext ctx)
        {
            _ctx = ctx;
        }
        public ICollection<StudenteEntity> Find(StudenteFilter filter)
        {

            IQueryable<StudenteEntity> query = ApplyFilter(_ctx, filter);

            return query.ToList(); // SELECT * FROM AnagreaficheStudenti WHERE  nome or cognome contains filter ....

        }
        public int Count(StudenteFilter filter)
        {
            IQueryable<StudenteEntity> query = ApplyFilter(_ctx, filter);

            return query.Count();
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

        public StudenteEntity Get(int id)
        {
            return _ctx.Studenti.FirstOrDefault(r => r.Id == id);
        }

        public StudenteEntity Post(StudenteEntity input)
        {
            // salvo i dati
            _ctx.Studenti.Add(input);
            _ctx.SaveChanges();

            return input;
        }

        public StudenteEntity Put(int id, StudenteEntity input)
        {
            var dbValue = _ctx.Studenti.FirstOrDefault(r => r.Id == id);
            if (dbValue == null) throw new ArgumentException($"Nessun dato trovato con id:{id}");

            // salvo i dati
            dbValue.DataDiNascita = input.DataDiNascita;
            dbValue.Nome = input.Nome;
            dbValue.Cognome = input.Cognome;
            dbValue.CodiceFiscale = input.CodiceFiscale;
            _ctx.SaveChanges();
            return dbValue;
        }

        public StudenteEntity Delete(int id)
        {
            var dbValue = _ctx.Studenti.FirstOrDefault(r => r.Id == id);
            if (dbValue == null) throw new ArgumentException($"Nessun dato trovato con id:{id}");

            // salvo i dati
            _ctx.Studenti.Remove(dbValue);
            _ctx.SaveChanges();
            return dbValue;
        }
    }
}
