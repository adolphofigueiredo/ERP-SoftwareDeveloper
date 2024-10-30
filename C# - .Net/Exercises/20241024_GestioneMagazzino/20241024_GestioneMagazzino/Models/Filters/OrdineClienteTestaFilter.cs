namespace _20241024_GestioneMagazzino.Models.Filters
{
    public class OrdineClienteTestaFilter
    {
        public int? IdCliente { get; set; }
        public DateOnly? DataInizio { get; set; }
        public DateOnly? DataFine { get; set; }
    }
}