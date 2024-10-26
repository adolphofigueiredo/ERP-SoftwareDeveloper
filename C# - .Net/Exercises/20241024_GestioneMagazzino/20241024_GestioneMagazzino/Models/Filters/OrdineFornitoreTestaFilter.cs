namespace _20241024_GestioneMagazzino.Models.Filters
{
    public class OrdineFornitoreTestaFilter
    {
        public int Id { get; set; }
        public int IdFornitore { get; set; }
        public DateOnly Data { get; set; }
    }
}