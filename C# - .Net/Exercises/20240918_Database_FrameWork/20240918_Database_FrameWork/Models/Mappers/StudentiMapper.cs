using _20240918_Database_FrameWork.Models.Dtos;
using _20240918_Database_FrameWork.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240918_Database_FrameWork.Models.Mappers
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
