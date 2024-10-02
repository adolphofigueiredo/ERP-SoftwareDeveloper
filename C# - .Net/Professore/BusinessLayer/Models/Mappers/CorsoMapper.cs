using BusinessLayer.Models.Dtos;
using BusinessLayer.Models.Entities;

namespace BusinessLayer.Models.Mappers
{
    public static class CorsoMapper
    {
        public static CorsoDto Map(CorsoEntity e)
        {
            if (e == null) return null;

            return new CorsoDto()
            {
                Id = e.Id,
                Nome = e.Nome,
                DataValiditaFine = e.DataValiditaFine,
                DataValiditaInizio = e.DataValiditaInizio,
            };

        }
    }
}
