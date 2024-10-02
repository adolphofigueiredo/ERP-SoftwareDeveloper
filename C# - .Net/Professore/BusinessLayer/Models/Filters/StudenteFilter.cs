using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models.Filters
{
    /// <summary>
    /// contiene tutti i parametri di ricerca
    /// </summary>
    public class StudenteFilter
    {
        public string Nominativo { get; set; }
        public DateTime? Da { get; set; }
        public DateTime? A { get; set; }
    }
}
