using _20241024_GestioneMagazzino.Models.Dto;
using _20241024_GestioneMagazzino.Models.Entities;

namespace _20241024_GestioneMagazzino.Mappers
{
    public static class OrdineClienteTestaMapper
    {
        public static OrdineClienteTestaDto Map(OrdineClienteTestaEntity e)
        {
            return new OrdineClienteTestaDto
            {
                Id = e.Id,
                IdCliente = e.IdCliente,
                Data = e.Data
            };
        }

        public static OrdineClienteTestaEntity Map(OrdineClienteTestaDto e)
        {
            return new OrdineClienteTestaEntity
            {
                Id = e.Id,
                IdCliente = e.IdCliente,
                Data = e.Data
            };
        }
    }
}
