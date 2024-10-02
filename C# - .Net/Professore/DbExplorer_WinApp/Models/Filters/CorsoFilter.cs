using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExplorer_WinApp.Models.Filters
{
    /// <summary>
    /// contiene tutti i parametri di ricerca
    /// </summary>
    public class CorsoFilter
    {
        public string Nome { get; set; }
        public DateTime? Da { get; set; }
        public DateTime? A { get; set; }
    }
}
