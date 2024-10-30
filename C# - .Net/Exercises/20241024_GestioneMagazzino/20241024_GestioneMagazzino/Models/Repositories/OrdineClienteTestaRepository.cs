using _20241024_GestioneMagazzino.Models;
using _20241024_GestioneMagazzino.Models.Entities;
using _20241024_GestioneMagazzino.Models.Filters;
using Microsoft.EntityFrameworkCore;

namespace _20241024_GestioneMagazzino.Repositories
{
    public class OrdineClienteTestaRepository 
    {
        private readonly GestioneMagazzinoContext _ctx;

        public OrdineClienteTestaRepository(GestioneMagazzinoContext ctx)
        {
            _ctx = ctx;
        }

        public ICollection<OrdineClienteTestaEntity> GetAll()
        {
            return _ctx.OrdineClienteTeste
                       .Include(o => o.Cliente)
                       .Include(o => o.Dettagli)
                       .ToList();
        }

        public OrdineClienteTestaEntity GetById(int id)
        {
            return _ctx.OrdineClienteTeste
                       .Include(o => o.Cliente)
                       .Include(o => o.Dettagli)
                       .FirstOrDefault(o => o.Id == id);
        }

        public OrdineClienteTestaEntity Create(OrdineClienteTestaEntity ordine)
        {
            _ctx.OrdineClienteTeste.Add(ordine);
            _ctx.SaveChanges();
            return ordine;
        }

        public OrdineClienteTestaEntity Update(int id, OrdineClienteTestaEntity ordine)
        {
            var existingOrder = GetById(id);
            if (existingOrder == null)
                throw new ArgumentException($"Ordine não encontrado com id: {id}");

            existingOrder.Data = ordine.Data;
            existingOrder.IdCliente = ordine.IdCliente;

            _ctx.SaveChanges();
            return existingOrder;
        }

        public void Delete(int id)
        {
            var ordine = GetById(id);
            if (ordine == null)
                throw new ArgumentException($"Ordine não encontrado com id: {id}");

            _ctx.OrdineClienteTeste.Remove(ordine);
            _ctx.SaveChanges();
        }
        public async Task<IEnumerable<OrdineClienteTestaEntity>> GetFilteredAsync(OrdineClienteTestaFilter filter)
        {
            var query = _ctx.OrdineClienteTeste.AsQueryable();

            if (filter.IdCliente.HasValue)
            {
                query = query.Where(o => o.IdCliente == filter.IdCliente.Value);
            }

            if (filter.DataInizio.HasValue)
            {
                query = query.Where(o => o.Data >= filter.DataInizio.Value);
            }

            if (filter.DataFine.HasValue)
            {
                query = query.Where(o => o.Data <= filter.DataFine.Value);
            }

            return await query.ToListAsync();
        }

    }
}
