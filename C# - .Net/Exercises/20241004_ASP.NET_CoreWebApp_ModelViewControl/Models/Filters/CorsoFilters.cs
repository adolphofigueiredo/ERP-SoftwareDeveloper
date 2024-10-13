

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.SqlServer.Server;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Filters
{
    public class CorsoFilter                //CorsolFilter é uma classe pública simples utilizada para agrupar critérios de
                                            //pesquisa e filtrar cursos no sistema. A principal função de uma classe de
                                            //filtro como essa é encapsular todos os parâmetros que serão usados em consultas
                                            //e buscas. Em vez de passar vários parâmetros soltos para uma função, ela passará 
                                            //um único objeto que contém todas as informações necessárias.
    {
        [DisplayName("Nome Corso: ")]       //Usado para definire o nome que será exibido na interface, facilitando o
        public string Nome { get; set; }    //Variável que receberá o valor digitado na caixa de texto e que deverá ser buscado.

        //[Required]                        //Caso a classe required fique ativa, este campo se tornarà obrigatorio.
        [DisplayName("Data da: ")]          //Usado para definire o nome que será exibido na interface, facilitando o
                                            //entendimento para o usuário.
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
                                            //Usado para deinir o formato de exibição da data. Isso garante que a data seja
                                            //mostrada no padrão dia/mês/ano.
        public DateTime? Da { get; set; }   //Variável que receberá o valor digitado na caixa de datas e que deverá ser buscado.

        //[Required]                        //Caso a classe required fique ativa, este campo se tornarà obrigatorio.
        [DisplayName("Data a: ")]           //Usado para definire o nome que será exibido na interface, facilitando o
                                            //entendimento para o usuário.
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
                                            //Usado para deinir o formato de exibição da data. Isso garante que a data seja
                                            //mostrada no padrão dia/mês/ano.
        public DateTime? A { get; set; }    //Variável que receberá o valor digitado na caixa de datas e que deverá ser buscado.
    }
}
