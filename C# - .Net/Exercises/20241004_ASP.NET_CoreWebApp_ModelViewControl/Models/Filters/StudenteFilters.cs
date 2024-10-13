
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Filters
{
    public class StudenteFilter                  //StudenteFilter é uma classe pública simples utilizada para agrupar critérios
                                                 //de pesquisa e filtrar estudantes no sistema. A principal função de uma classe
                                                 //de filtro como essa é encapsular todos os parâmetros que serão usados em
                                                 //consultas e buscas. Em vez de passar vários parâmetros soltos para uma função,
                                                 //ela passará um único objeto que contém todas as informações necessárias.
    {
        [DisplayName("Studente: ")]              //Usado para definire o nome que será exibido na interface, facilitando o
                                                 //entendimento para o usuário.
        public string Nominativo { get; set; }   //Variável que receberá o valor digitado na caixa de texto e que deverá ser buscado.

        //[Required]                             //Caso a classe required fique ativa, este campo se tornarà obrigatorio.
        [DisplayName("Data da: ")]               //Usado para definire o nome que será exibido na interface, facilitando o
                                                 //entendimento para o usuário.
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
                                                 //Usado para deinir o formato de exibição da data. Isso garante que a data seja
                                                 //mostrada no padrão dia/mês/ano.
        public DateTime? Da { get; set; }        //Variável que receberá o valor digitado na caixa de datas e que deverá ser buscado.

        //[Required]                             //Caso a classe required fique ativa, este campo se tornarà obrigatorio.
        [DisplayName("Data a: ")]                //Usado para definire o nome que será exibido na interface, facilitando o
                                                 //entendimento para o usuário.
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
                                                 //Usado para deinir o formato de exibição da data. Isso garante que a data seja
                                                 //mostrada no padrão dia/mês/ano.
        public DateTime? A { get; set; }         //Variável que receberá o valor digitado na caixa de datas e que deverá ser buscado.
    }
}
