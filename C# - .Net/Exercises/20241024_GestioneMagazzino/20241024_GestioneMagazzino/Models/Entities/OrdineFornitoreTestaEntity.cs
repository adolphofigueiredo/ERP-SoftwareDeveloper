namespace _20241024_GestioneMagazzino.Models.Entities
{
    public class OrdineFornitoreTestaEntity
    {
        public int Id { get; set; }
        public int IdFornitore { get; set; }
        public virtual FornitoreEntity Fornitore { get; set; }
        public DateOnly Data { get; set; }
        public virtual ICollection<OrdineFornitoreDettaglioEntity> Dettagli { get; set; }
    }
}