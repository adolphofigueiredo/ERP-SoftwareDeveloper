namespace _20241024_GestioneMagazzino.Models.Filters
{
    public class OrdineClienteDettaglioFilter
    {
        public int Id { get; set; }
        public int IdOrdineClienteTesta { get; set; }
        public int IdProdotto { get; set; }
        public decimal Quantita { get; set; }
    }
}