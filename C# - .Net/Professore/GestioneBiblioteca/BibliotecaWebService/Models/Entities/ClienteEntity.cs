namespace BibliotecaWebService.Models.Entities
{
	public class ClienteEntity
	{
		public ClienteEntity()
		{
			Prestiti = new HashSet<PrestitoEntity>();
		}
		public string CodiceFiscale { get; set; }
		public string Nome { get; set; }
		public string Cognome { get; set; }

		public virtual ICollection<PrestitoEntity> Prestiti { get; set; }
	}
}
