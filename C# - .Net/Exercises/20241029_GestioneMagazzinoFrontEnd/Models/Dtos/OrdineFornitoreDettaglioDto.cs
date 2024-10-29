using System.ComponentModel;

namespace _20241029_GestioneMagazzinoFrontEnd.Models.Dto
{
    public class OrdineFornitoreDettaglioDto
    {
        public int Id { get; set; }
        public int IdOrdineFornitoreTesta { get; set; }
        public int IdProdotto { get; set; }
        public decimal Quantita { get; set; }
    }
}