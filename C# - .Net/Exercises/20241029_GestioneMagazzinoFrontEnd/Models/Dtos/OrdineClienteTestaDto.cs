using System.ComponentModel;

namespace _20241029_GestioneMagazzinoFrontEnd.Models.Dto
{
    public class OrdineClienteTestaDto
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateOnly Data { get; set; }
    }
}