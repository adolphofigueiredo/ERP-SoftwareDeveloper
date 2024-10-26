namespace _20241024_GestioneMagazzino.Models.Filters
{
    public class OrdineClienteTestaFilter
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateOnly Data { get; set; }
    }
}