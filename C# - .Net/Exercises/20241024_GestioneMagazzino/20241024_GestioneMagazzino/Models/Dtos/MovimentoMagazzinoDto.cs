namespace _20241024_GestioneMagazzino.Models.Dto
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