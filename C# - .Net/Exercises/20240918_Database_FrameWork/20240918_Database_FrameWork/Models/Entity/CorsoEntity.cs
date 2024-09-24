using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240918_Database_FrameWork.Models.Entity
{
    public class CorsoEntity
    {
        public CorsoEntity()
        { 
            Studente = new HashSet<StudenteEntity>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public DateTime DataValiditaInizio { get; set; }

        public DateTime DataValiditaFine { get; set; }

        public virtual ICollection<StudenteEntity> Studente { get; set; }

    }
}
