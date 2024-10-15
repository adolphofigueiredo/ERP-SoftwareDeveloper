namespace BibliotecaWebService.Models.Entities
{
	public class LibroEntity
	{
		public LibroEntity()
		{
			Prestiti = new HashSet<PrestitoEntity>();
		}

		public string ISBN { get; set; }
		public string Titolo { get; set; }
		public string Autori { get; set; }

		public ICollection<PrestitoEntity> Prestiti { get; set; }
	}
}
