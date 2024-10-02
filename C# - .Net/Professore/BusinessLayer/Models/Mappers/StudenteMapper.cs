using BusinessLayer.Models.Dtos;
using BusinessLayer.Models.Entities;

namespace BusinessLayer.Models.Mappers
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
