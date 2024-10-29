using System.ComponentModel;

namespace _20241029_GestioneMagazzinoFrontEnd.Models.Dto
{
    public class OrdineClienteDettaglioDto
    {
        public int Id { get; set; }
        public int IdOrdineClienteTesta { get; set; }
        public int IdProdotto { get; set; }
        public decimal Quantita { get; set; }
    }
}