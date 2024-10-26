namespace _20241024_GestioneMagazzino.Models.Filters
{
    public class OrdineFornitoreDettaglioFilter
    {
        public int Id { get; set; }
        public int IdOrdineFornitoreTesta { get; set; }
        public int IdProdotto { get; set; }
        public decimal Quantita { get; set; }
    }
}