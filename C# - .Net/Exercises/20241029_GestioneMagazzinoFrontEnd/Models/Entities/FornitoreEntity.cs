namespace _20241029_GestioneMagazzinoFrontEnd.Models.Entities
{
    public class FornitoreEntity
    { 
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<OrdineFornitoreTestaEntity> Ordini { get; set; }
    }
}