using _20241024_GestioneMagazzino.Models.Dto;
using _20241024_GestioneMagazzino.Models.Entities;

namespace _20241024_GestioneMagazzino.Models.Mappers
{
    public static class FornitoriMapper
    {
        public static FornitoreDto Map(FornitoreEntity e)
        {

            if (e == null) return null;

            return new FornitoreDto()
            {

                Nome = e.Nome,

            };

        }
        public static FornitoreEntity Map(FornitoreDto e)
        {

            if (e == null) return null;

            return new FornitoreEntity()
            {

                Nome = e.Nome,

            };

        }
        public static FornitoreDto From(FornitoreEntity e)
        {

            if (e == null) return null;

            return new FornitoreDto()
            {

                Nome = e.Nome,

            };
        }
        public static FornitoreEntity From(FornitoreDto e)
        {
            if (e == null) return null;

            return new FornitoreEntity()
            {

                Nome = e.Nome,

            };
        }
    }
}
