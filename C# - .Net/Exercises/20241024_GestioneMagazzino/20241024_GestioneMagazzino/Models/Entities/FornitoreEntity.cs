namespace _20241024_GestioneMagazzino.Models.Entities
{
    public class FornitoreEntity
    { 
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<OrdineFornitoreTestaEntity> Ordini { get; set; }
    }
}