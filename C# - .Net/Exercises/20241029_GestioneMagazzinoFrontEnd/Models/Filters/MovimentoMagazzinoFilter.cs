namespace _20241029_GestioneMagazzinoFrontEnd.Models.Filters
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