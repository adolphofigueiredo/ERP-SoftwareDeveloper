using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Filters;
using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Dtos;

namespace _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.PageViewModels
{
    public class StudentiIndexViewModel                                        //A ViewModel no padrão MVC (Model-View-Controller) atua como um intermediário
                                                                               //entre o Controller e a View. Ela encapsula as informações que a View precisa
                                                                               //para exibir os dados ao usuário, bem como os parâmetros de entrada que podem
                                                                               //ser usados para a lógica de negócio, como filtros de pesquisa. Ela é usada
                                                                               //para exibir os dados filtrados e renderizar a lista de resultados de estudantes
                                                                               //na página.
    {
        public StudenteFilter Filter { get; set; }                             //Esse é um filtro que permite restringir ou ajustar os dados dos estudantes
                                                                               //conforme os critérios fornecidos. Ele contém as propriedades e a lógica para
                                                                               //realizar filtragem com base em parâmetros como nome, sobrenome, ID, etc.
        public ICollection<StudenteDto> ElementiTrovati { get; set; }          //Representa uma coleção dos estudantes que correspondem aos critérios definidos
                                                                               //pelo filtro. Cada item na coleção é uma instância de StudenteDto, que contém
                                                                               //os dados necessários (provavelmente um subconjunto dos campos do modelo
                                                                               //original) para serem exibidos na interface de usuário.
    }
}
