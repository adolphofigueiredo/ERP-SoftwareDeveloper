namespace _20241029_GestioneMagazzinoFrontEnd.Models.Filters
{
    public class OrdineClienteTestaFilter
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateOnly Data { get; set; }
    }
}