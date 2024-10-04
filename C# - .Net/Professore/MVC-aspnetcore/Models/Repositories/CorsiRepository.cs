using MVC_aspnetcore.Models.Entities;
using MVC_aspnetcore.Models.Filters;

namespace MVC_aspnetcore.Models.Repositories
{
	public class CorsiRepository
	{
		private readonly ItsCorsiEsamiContext _ctx;

		public CorsiRepository(ItsCorsiEsamiContext ctx)
		{
			_ctx = ctx;

		}
		public ICollection<CorsoEntity> Find(CorsoFilter filter)
		{
			IQueryable<CorsoEntity> query = ApplyFilter(_ctx, filter);

			return query.ToList(); // SELECT * FROM AnagreaficheStudenti WHERE  nome or cognome contains filter ....
		}
		public int Count(CorsoFilter filter)
		{
			IQueryable<CorsoEntity> query = ApplyFilter(_ctx, filter);

			return query.Count();
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
			return _ctx.Corsi.FirstOrDefault(r => r.Id == id);
		}

		public CorsoEntity Post(CorsoEntity input)
		{
			// salvo i dati
			_ctx.Corsi.Add(input);
			_ctx.SaveChanges();

			return input;
		}

		public CorsoEntity Put(int id, CorsoEntity input)
		{
			var dbValue = _ctx.Corsi.FirstOrDefault(r => r.Id == id);
			if (dbValue == null) throw new ArgumentException($"Nessun dato trovato con id:{id}");

			// salvo i dati
			dbValue.Nome = input.Nome;
			dbValue.DataValiditaFine = input.DataValiditaFine;
			dbValue.DataValiditaInizio = input.DataValiditaInizio;

			_ctx.SaveChanges();
			return dbValue;
		}

		public CorsoEntity Delete(int id)
		{
			var dbValue = _ctx.Corsi.FirstOrDefault(r => r.Id == id);
			if (dbValue == null) throw new ArgumentException($"Nessun dato trovato con id:{id}");

			// salvo i dati
			_ctx.Corsi.Remove(dbValue);
			_ctx.SaveChanges();
			return dbValue;
		}

		public ICollection<CorsoEntity> GetCorsiValidi(DateTime dt)
		{
			var q = _ctx.Corsi.Where(c =>
				c.DataValiditaInizio <= dt &&
				c.DataValiditaFine == null || c.DataValiditaFine > DateTime.Now).ToList();

			return q.ToList();
		}
	}
}
