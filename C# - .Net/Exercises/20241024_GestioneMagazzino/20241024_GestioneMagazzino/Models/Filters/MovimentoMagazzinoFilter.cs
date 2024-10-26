namespace _20241024_GestioneMagazzino.Models.Filters
{
    public class MovimentoMagazzinoFilter
    {
        public int Id { get; set; }
        public int IdOrdineClienteDettaglio { get; set; }
        public int IdOrdineFornitoreDettaglio { get; set; }
        public int IdProdotto { get; set; }
        public decimal Quantita { get; set; }
    }
}