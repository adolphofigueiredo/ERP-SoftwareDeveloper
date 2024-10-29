namespace _20241029_GestioneMagazzinoFrontEnd.Models.Entities
{
    public class MovimentoMagazzinoEntity
    {
        public int Id { get; set; }
        public int IdOrdineClienteDettaglio { get; set; }
        public virtual OrdineClienteDettaglioEntity OrdineClienteDettaglio { get; set; }
        public int IdOrdineFornitoreDettaglio { get; set; }
        public virtual OrdineFornitoreDettaglioEntity OrdineFornitoreDettaglio { get; set; }
        public int IdProdotto { get; set; }
        public virtual ProdottoEntity Prodotto { get; set; }
        public decimal Quantita { get; set; }
    }
}