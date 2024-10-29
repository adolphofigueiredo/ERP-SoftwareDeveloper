using System.ComponentModel;

namespace _20241029_GestioneMagazzinoFrontEnd.Models.Dto
{
    public class FornitoreDto
    { 
        public int Id { get; set; }

        [DisplayName("Nome Fornitore: ")]
        public string Nome { get; set; }
    }
}