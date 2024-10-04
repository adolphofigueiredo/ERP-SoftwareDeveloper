using System;
using System.Collections.Generic;

namespace MVC_aspnetcore.Models.Entities
{
	public class CorsoEntity
	{
		public CorsoEntity()
		{
			Studenti = new HashSet<StudenteEntity>();
		}

		public int Id { get; set; }
		public string Nome { get; set; }
		public DateTime DataValiditaInizio { get; set; }
		public DateTime? DataValiditaFine { get; set; }

		public virtual ICollection<StudenteEntity> Studenti { get; set; }

	}
}
