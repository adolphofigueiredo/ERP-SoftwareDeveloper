namespace _20241024_GestioneMagazzino.Models.Entities
{
    public class OrdineFornitoreDettaglioEntity
    {
        public int Id { get; set; }
        public int IdOrdineFornitoreTesta { get; set; }
        public virtual OrdineFornitoreTestaEntity OrdineFornitoreTesta { get; set; }
        public int IdProdotto { get; set; }
        public virtual ProdottoEntity Prodotto { get; set; }
        public decimal Quantita { get; set; }
    }
}