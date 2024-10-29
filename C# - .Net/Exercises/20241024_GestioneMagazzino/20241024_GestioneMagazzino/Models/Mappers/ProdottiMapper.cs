using _20241024_GestioneMagazzino.Models.Dto;
using _20241024_GestioneMagazzino.Models.Entities;

namespace _20241024_GestioneMagazzino.Models.Mappers
{
    public static class ProdottiMapper
    {
        public static ProdottoDto Map(ProdottoEntity e)
        {

            if (e == null) return null;

            return new ProdottoDto()
            {

                Descrizione = e.Descrizione,
                Altezza = e.Altezza,
                Larghezza = e.Larghezza,
                Profondita = e.Larghezza,
                Peso = e.Peso,
            };

        }
        public static ProdottoEntity Map(ProdottoDto e)
        {

            if (e == null) return null;

            return new ProdottoEntity()
            {

                Descrizione = e.Descrizione,
                Altezza = e.Altezza,
                Larghezza = e.Larghezza,
                Profondita = e.Larghezza,
                Peso = e.Peso,

            };

        }
        public static ProdottoDto From(ProdottoEntity e)
        {

            if (e == null) return null;

            return new ProdottoDto()
            {

                Descrizione = e.Descrizione,
                Altezza = e.Altezza,
                Larghezza = e.Larghezza,
                Profondita = e.Larghezza,
                Peso = e.Peso,

            };
        }
        public static ProdottoEntity From(ProdottoDto e)
        {
            if (e == null) return null;

            return new ProdottoEntity()
            {

                Descrizione = e.Descrizione,
                Altezza = e.Altezza,
                Larghezza = e.Larghezza,
                Profondita = e.Larghezza,
                Peso = e.Peso,

            };
        }
    }
}
