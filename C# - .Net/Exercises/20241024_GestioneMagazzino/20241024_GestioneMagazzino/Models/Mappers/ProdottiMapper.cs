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
                Id = e.Id,
                Descrizione = e.Descrizione,
                Altezza = e.Altezza,
                Larghezza = e.Larghezza,
                Profondita = e.Profondita,
                Peso = e.Peso
            };
        }

        public static ProdottoEntity Map(ProdottoDto e)
        {
            if (e == null) return null;

            return new ProdottoEntity()
            {
                Id = e.Id,
                Descrizione = e.Descrizione,
                Altezza = e.Altezza,
                Larghezza = e.Larghezza,
                Profondita = e.Profondita,
                Peso = e.Peso
            };
        }
    }
}
