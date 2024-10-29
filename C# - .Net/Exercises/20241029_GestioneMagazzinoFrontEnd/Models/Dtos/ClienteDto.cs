using System.ComponentModel;

namespace _20241029_GestioneMagazzinoFrontEnd.Models.Dto
{
    public class ClienteDto
    {
        public int Id { get; set; }

        [DisplayName("Nome Cliente: ")]
        public string Nome { get; set; }
    }
}