using DbExplorer_WinApp.Models.Dtos;
using DbExplorer_WinApp.Models.Entities;

namespace DbExplorer_WinApp.Models.Mappers
{
    public static class StudenteMapper
    {
        public static StudenteDto Map(StudenteEntity studenteEntity)
        {
            if (studenteEntity == null) return null;

            return new StudenteDto()
            {
                CodiceFiscale = studenteEntity.CodiceFiscale,
                Cognome = studenteEntity.Cognome,
                Nome = studenteEntity.Nome,
                CorsoId = studenteEntity.CorsoId,
                DataDiNascita = studenteEntity.DataDiNascita,
                Id = studenteEntity.Id,
            };

        }
    }
}
