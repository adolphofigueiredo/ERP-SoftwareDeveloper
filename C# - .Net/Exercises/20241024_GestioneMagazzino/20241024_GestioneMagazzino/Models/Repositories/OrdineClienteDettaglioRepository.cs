using _20241024_GestioneMagazzino.Models;
using _20241024_GestioneMagazzino.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace _20241024_GestioneMagazzino.Repositories
{
    public class OrdineClienteDettaglioRepository
    {
        private readonly GestioneMagazzinoContext _ctx;
        private readonly ILogger<OrdineClienteDettaglioRepository> _logger;

        public OrdineClienteDettaglioRepository(GestioneMagazzinoContext ctx, ILogger<OrdineClienteDettaglioRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        // Método para criar um novo detalhe de pedido
        public async Task<OrdineClienteDettaglioEntity> CreateAsync(OrdineClienteDettaglioEntity dettaglio)
        {
            var existingDetail = await GetByIdAsync(dettaglio.Id); // Use lógica do GetByIdAsync para buscar

            if (existingDetail != null) // Se já existe, trata como atualização
            {
                existingDetail.IdOrdineClienteTesta = dettaglio.IdOrdineClienteTesta;
                existingDetail.IdProdotto = dettaglio.IdProdotto;
                existingDetail.Quantita = dettaglio.Quantita;
                await _ctx.SaveChangesAsync();
                return existingDetail;
            }

            // Verificação de OrdineClienteTesta e Prodotto como em CreateAsync
            var ordineClienteTesta = await _ctx.OrdineClienteTeste.FindAsync(dettaglio.IdOrdineClienteTesta);
            if (ordineClienteTesta == null)
                throw new ArgumentException($"OrdineClienteTesta with id: {dettaglio.IdOrdineClienteTesta} not found");

            var prodotto = await _ctx.Prodotti.FindAsync(dettaglio.IdProdotto);
            if (prodotto == null)
                throw new ArgumentException($"Prodotto with id: {dettaglio.IdProdotto} not found");

            // Adiciona novo detalhe
            _ctx.OrdineClienteDettagli.Add(dettaglio);
            await _ctx.SaveChangesAsync();
            return dettaglio;
        }

        // Método para obter um detalhe de pedido pelo ID
        public async Task<OrdineClienteDettaglioEntity> GetByIdAsync(int id)
        {
            return await _ctx.OrdineClienteDettagli
                             .Include(d => d.OrdineClienteTesta) // Incluir a entidade relacionada se necessário
                             .FirstOrDefaultAsync(d => d.Id == id);
        }

        // Método para obter todos os detalhes de pedido com filtros opcionais
        public async Task<IEnumerable<OrdineClienteDettaglioEntity>> GetAllAsync(int? idOrdineClienteTesta = null, int? idProdotto = null)
        {
            var query = _ctx.OrdineClienteDettagli.AsQueryable();

            if (idOrdineClienteTesta.HasValue)
            {
                query = query.Where(d => d.IdOrdineClienteTesta == idOrdineClienteTesta.Value);
            }

            if (idProdotto.HasValue)
            {
                query = query.Where(d => d.IdProdotto == idProdotto.Value);
            }

            return await query.ToListAsync();
        }

        // Método para atualizar apenas a quantidade de um detalhe de pedido
        public async Task<OrdineClienteDettaglioEntity> UpdateAsync(int id, OrdineClienteDettaglioEntity dettaglio)
        {
            var existingDetail = await GetByIdAsync(id);
            if (existingDetail == null)
                throw new ArgumentException($"Order detail with id: {id} not found");

            // Atualiza todos os campos necessários
            existingDetail.IdOrdineClienteTesta = dettaglio.IdOrdineClienteTesta;
            existingDetail.IdProdotto = dettaglio.IdProdotto;
            existingDetail.Quantita = dettaglio.Quantita;

            await _ctx.SaveChangesAsync();
            return existingDetail;
        }

        // Método para deletar um detalhe de pedido
        public async Task DeleteAsync(int id)
        {
            var dettaglio = await GetByIdAsync(id);
            if (dettaglio == null)
                throw new ArgumentException($"Order detail with id: {id} not found");

            _ctx.OrdineClienteDettagli.Remove(dettaglio);
            await _ctx.SaveChangesAsync();
        }
    }
}
