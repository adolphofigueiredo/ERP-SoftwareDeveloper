using BibliotecaWebService.Models.Dtos;
using BibliotecaWebService.Models.Entities;

namespace BibliotecaWebService.Models
{
	public static class ClientiMapper
	{
		public static ClienteEntity From(ClienteDto dto)
		{
			if (dto == null) return null;
			return new ClienteEntity()
			{
				CodiceFiscale = dto.CodiceFiscale,
				Cognome = dto.Cognome,
				Nome = dto.Nome
			};
		}
		public static ClienteDto From(ClienteEntity dto)
		{
			if (dto == null) return null;
			return new ClienteDto()
			{
				CodiceFiscale = dto.CodiceFiscale,
				Cognome = dto.Cognome,
				Nome = dto.Nome
			};
		}
	}
}
