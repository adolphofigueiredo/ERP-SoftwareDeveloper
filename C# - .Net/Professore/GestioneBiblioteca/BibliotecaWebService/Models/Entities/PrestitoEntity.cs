namespace BibliotecaWebService.Models.Entities
{
	public class PrestitoEntity
	{
		public DateTime DataInizio { get; set; }
		public DateTime? DataFine { get; set; }

		public string ISBN { get; set; }
		public virtual LibroEntity Libro { get; set; }

		public string CodiceFiscale { get; set; }
		public virtual ClienteEntity Cliente { get; set; }

	}
}
