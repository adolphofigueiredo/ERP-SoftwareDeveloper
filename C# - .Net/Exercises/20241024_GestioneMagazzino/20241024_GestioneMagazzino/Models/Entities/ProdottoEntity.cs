namespace _20241024_GestioneMagazzino.Models.Entities
{
    public class ProdottoEntity
    {
        public int Id { get; set; }
        public string Descrizione { get; set; }
        public int Altezza { get; set; }
        public int Larghezza { get; set; }
        public int Profondita { get; set; }
        public int Peso { get; set; }
        public virtual ICollection<OrdineClienteDettaglioEntity> OrdineClienteDettagli { get; set; }
        public virtual ICollection<OrdineFornitoreDettaglioEntity> OrdineFornitoreDettagli { get; set; }
        public virtual ICollection<MovimentoMagazzinoEntity> MovimentiMagazzino { get; set; }  
    }
}