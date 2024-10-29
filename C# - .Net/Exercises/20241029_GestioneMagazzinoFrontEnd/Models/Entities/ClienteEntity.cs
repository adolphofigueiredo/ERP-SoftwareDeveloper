namespace _20241029_GestioneMagazzinoFrontEnd.Models.Entities
{
    public class ClienteEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<OrdineClienteTestaEntity> Ordini { get; set; }
    }
}