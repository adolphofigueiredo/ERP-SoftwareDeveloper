namespace _20241024_GestioneMagazzino.Models.Dto
{
    public class OrdineClienteTestaDto
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateOnly Data { get; set; }
    }
}