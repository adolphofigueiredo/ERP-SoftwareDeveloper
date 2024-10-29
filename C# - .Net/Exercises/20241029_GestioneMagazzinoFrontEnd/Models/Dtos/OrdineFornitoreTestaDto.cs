using System.ComponentModel;

namespace _20241029_GestioneMagazzinoFrontEnd.Models.Dto
{
    public class OrdineFornitoreTestaDto
    {
        public int Id { get; set; }
        public int IdFornitore { get; set; }
        public DateOnly Data { get; set; }
    }
}