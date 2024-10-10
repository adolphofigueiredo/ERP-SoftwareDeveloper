using MVC_aspnetcore.Models.Dtos;
using MVC_aspnetcore.Models.Filters;

namespace MVC_aspnetcore.Models.PageViewModels
{
	public class StudentiIndexViewModel
	{
		public StudenteFilter Filter { get; set; }
		public ICollection<StudenteDto> ElementiTrovati { get; set; }
	}
}
