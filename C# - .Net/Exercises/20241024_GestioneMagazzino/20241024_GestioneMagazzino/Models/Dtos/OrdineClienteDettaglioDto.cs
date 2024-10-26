namespace _20241024_GestioneMagazzino.Models.Dto
{
    public class OrdineClienteDettaglioDto
    {
        public int Id { get; set; }
        public int IdOrdineClienteTesta { get; set; }
        public int IdProdotto { get; set; }
        public decimal Quantita { get; set; }
    }
}