using DbExplorer_WinApp.Models.Entities;

namespace DbExplorer_WinApp.Models.Mappers
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
