using System;

namespace MVC_aspnetcore.Models.Dtos
{
	public class CorsoDto
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public DateTime DataValiditaInizio { get; set; }
		public DateTime? DataValiditaFine { get; set; }

	}
}
