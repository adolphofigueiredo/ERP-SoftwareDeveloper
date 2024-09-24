using System;

namespace DbExplorer_WinApp.Models.Entities
{
    public class CorsoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataValiditaInizio { get; set; }
        public DateTime? DataValiditaFine { get; set; }

    }
}
