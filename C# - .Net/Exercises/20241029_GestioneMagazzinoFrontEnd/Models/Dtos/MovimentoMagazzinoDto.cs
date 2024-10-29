using System.ComponentModel;

namespace _20241029_GestioneMagazzinoFrontEnd.Models.Dto
{
    public class MovimentoMagazzinoDto
    {
        public int Id { get; set; }
        public int IdOrdineClienteDettaglio { get; set; }
        public int IdOrdineFornitoreDettaglio { get; set; }
        public int IdProdotto { get; set; }
        public decimal Quantita { get; set; }
    }
}