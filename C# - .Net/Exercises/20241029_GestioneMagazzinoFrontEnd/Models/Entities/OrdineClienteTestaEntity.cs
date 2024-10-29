namespace _20241029_GestioneMagazzinoFrontEnd.Models.Entities
{
    public class OrdineClienteTestaEntity
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public virtual ClienteEntity Cliente { get; set; }
        public DateOnly Data { get; set; }
        public virtual ICollection<OrdineClienteDettaglioEntity> Dettagli { get; set; }
    }
}