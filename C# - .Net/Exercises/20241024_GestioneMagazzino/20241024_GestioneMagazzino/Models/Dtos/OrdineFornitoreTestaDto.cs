namespace _20241024_GestioneMagazzino.Models.Dto
{
    public class OrdineFornitoreTestaDto
    {
        public int Id { get; set; }
        public int IdFornitore { get; set; }
        public DateOnly Data { get; set; }
    }
}