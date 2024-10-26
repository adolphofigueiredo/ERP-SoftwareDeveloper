using _20241024_GestioneMagazzino.Models.Dto;
using _20241024_GestioneMagazzino.Models.Entities;

namespace _20241024_GestioneMagazzino.Models.Mappers
{
    public static class ClienteMapper
    {
        public static ClienteDto Map(ClienteEntity e)
        {

            if (e == null) return null;

            return new ClienteDto()
            {

                Nome = e.Nome,

            };

        }
        public static ClienteEntity Map(ClienteDto e)
        {

            if (e == null) return null;

            return new ClienteEntity()
            {

                Nome = e.Nome,

            };

        }

    }
}
