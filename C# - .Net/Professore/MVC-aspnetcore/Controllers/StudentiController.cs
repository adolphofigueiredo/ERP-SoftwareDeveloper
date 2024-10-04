using Microsoft.AspNetCore.Mvc;
using MVC_aspnetcore.Models.Dtos;
using MVC_aspnetcore.Models.Filters;
using MVC_aspnetcore.Models.Mappers;
using MVC_aspnetcore.Models.Repositories;

namespace MVC_aspnetcore.Controllers
{
	public class StudentiController : Controller
	{
		private readonly StudentiRepository _studentiRepository;

		public StudentiController(StudentiRepository studentiRepository)
		{
			_studentiRepository = studentiRepository;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Search([FromQuery] StudenteFilter filter)
		{
			var studentiTrovati = _studentiRepository.Find(filter);
			List<StudenteDto> studentiDto = studentiTrovati
				.Select(r => StudenteMapper.Map(r))
				.ToList();

			return View(studentiDto);
		}

	}
}
