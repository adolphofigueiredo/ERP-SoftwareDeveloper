namespace _20241024_GestioneMagazzino.Models.Entities
{
    public class OrdineClienteDettaglioEntity
    {
        public int Id { get; set; }
        public int IdOrdineClienteTesta { get; set; }
        public virtual OrdineClienteTestaEntity OrdineClienteTesta { get; set; }
        public int IdProdotto { get; set; }
        public virtual ProdottoEntity Prodotto { get; set; }
        public decimal Quantita { get; set; }
    }
}