using System;

namespace MVC_aspnetcore.Models.Entities
{
	public class StudenteEntity
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Cognome { get; set; }
		public string CodiceFiscale { get; set; }
		public DateTime DataDiNascita { get; set; }

		public int CorsoId { get; set; }
		public virtual CorsoEntity Corso { get; set; }

	}
}
