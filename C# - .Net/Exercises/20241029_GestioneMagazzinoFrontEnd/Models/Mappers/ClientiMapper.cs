using _20241029_GestioneMagazzinoFrontEnd.Models.Dto;
using _20241029_GestioneMagazzinoFrontEnd.Models.Entities;

namespace _20241029_GestioneMagazzinoFrontEnd.Models.Mappers
{
    public static class ClientiMapper
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
        public static ClienteDto From(ClienteEntity e)
        {

            if (e == null) return null;

            return new ClienteDto()
            {

                Nome = e.Nome,

            };
        }
        public static ClienteEntity From(ClienteDto e)
        {
            if (e == null) return null;

            return new ClienteEntity()
            {

                Nome = e.Nome,

            };
        }
    }
}
