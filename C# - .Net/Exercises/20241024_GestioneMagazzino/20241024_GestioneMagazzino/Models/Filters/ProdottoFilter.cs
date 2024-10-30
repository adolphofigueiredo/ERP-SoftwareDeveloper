namespace _20241024_GestioneMagazzino.Models.Filters

{
    public class ProdottoFilter
    {
        public int Id { get; set; }
        public string? Descrizione { get; set; }
        public int Altezza { get; set; }
        public int Larghezza { get; set; }
        public int Profondita { get; set; }
        public int Peso { get; set; }
    }
}