using _20241024_GestioneMagazzino.Models.Dto;
using _20241024_GestioneMagazzino.Models.Entities;

namespace _20241024_GestioneMagazzino.Mappers
{
    public static class OrdineClienteDettaglioMapper
    {
        public static OrdineClienteDettaglioDto Map(OrdineClienteDettaglioEntity entity)
        {
            return new OrdineClienteDettaglioDto
            {
                Id = entity.Id,
                IdOrdineClienteTesta = entity.IdOrdineClienteTesta,
                IdProdotto = entity.IdProdotto,
                Quantita = entity.Quantita
            };
        }

        public static OrdineClienteDettaglioEntity Map(OrdineClienteDettaglioDto dto)
        {
            return new OrdineClienteDettaglioEntity
            {
                Id = dto.Id,
                IdOrdineClienteTesta = dto.IdOrdineClienteTesta,
                IdProdotto = dto.IdProdotto,
                Quantita = dto.Quantita
            };
        }
    }
}
