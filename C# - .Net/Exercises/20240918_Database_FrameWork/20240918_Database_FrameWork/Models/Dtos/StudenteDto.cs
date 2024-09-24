using _20240918_Database_FrameWork.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240918_Database_FrameWork.Models.Dtos
{
    public class StudenteDto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Cognome { get; set; }
            public string CodiceFiscale { get; set; }
            public DateTime DataDiNascita { get; set; }
            public int CorsoId { get; set; }
        }
    }