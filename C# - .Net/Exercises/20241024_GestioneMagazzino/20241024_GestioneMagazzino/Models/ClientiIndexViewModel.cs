using _20241024_GestioneMagazzino.Models.Dto;
using _20241024_GestioneMagazzino.Models.Filters;

namespace _20241024_GestioneMagazzino.Models
{
    public class ClientiIndexViewModel
    {

        public ClienteFilter Filter { get; set; }

        public ICollection<ClienteDto> ElementiTrovati { get; set; }

    }
}
