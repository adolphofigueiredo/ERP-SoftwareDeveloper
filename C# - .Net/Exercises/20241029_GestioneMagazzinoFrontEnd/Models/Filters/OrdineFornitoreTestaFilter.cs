namespace _20241029_GestioneMagazzinoFrontEnd.Models.Filters
{
    public class OrdineFornitoreTestaFilter
    {
        public int Id { get; set; }
        public int IdFornitore { get; set; }
        public DateOnly Data { get; set; }
    }
}