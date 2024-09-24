using _20240918_Database_FrameWork.Models.Dtos;
using _20240918_Database_FrameWork.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240918_Database_FrameWork.Models.Mappers
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
