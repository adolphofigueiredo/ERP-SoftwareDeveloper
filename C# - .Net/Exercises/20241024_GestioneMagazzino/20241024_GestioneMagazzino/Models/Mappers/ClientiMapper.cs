using _20241024_GestioneMagazzino.Models.Dto;
using _20241024_GestioneMagazzino.Models.Entities;

namespace _20241024_GestioneMagazzino.Models.Mappers
{
    public static class ClientiMapper
    {
        public static ClienteDto Map(ClienteEntity e)
        {

            if (e == null) return null;

            return new ClienteDto()
            {
                Id = e.Id,
                Nome = e.Nome,
            };
        }
        public static ClienteEntity Map(ClienteDto e)
        {

            if (e == null) return null;

            return new ClienteEntity()
            {
                Id = e.Id,
                Nome = e.Nome,
            };
        }
    }
}
