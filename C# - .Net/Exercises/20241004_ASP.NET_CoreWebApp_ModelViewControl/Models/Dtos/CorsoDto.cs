using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Dtos
{
        public class CorsoDto                                        //A classe é pública, o que significa que pode ser acessada de qualquer
                                                                     //outro código no projeto. A classe StudenteDto serve como um objeto de
                                                                     //transferência de dados para um estudante, facilitando a transferência
                                                                     //de informações de um lugar para outro, sem expor diretamente a
                                                                     //entidade do banco de dados.
        {
            public int Id { get; set; }                              //Identificador único do curso. O get permite que o valor seja lido e o
                                                                     //set permite que o valor seja alterado.

            [Required(ErrorMessage ="Il campo è obbligatorio")]      //Este campo se tornarà obrigatorio.
            [DisplayName("Nome: ")]                                  //Usado para definire o nome que será exibido na interface, facilitando o
                                                                     //entendimento para o usuário.
            public string Nome { get; set; }                         //Armazena o nome do curso. O get permite que o valor seja lido e o set
                                                                     //permite que o valor seja alterado.

            [Required(ErrorMessage = "Il campo è obbligatorio")]      //Este campo se tornarà obrigatorio.
            [DisplayName("Validità da: ")]                           //Usado para definire o nome que será exibido na interface, facilitando o
                                                                     //entendimento para o usuário.

            public DateTime DataValiditaInizio { get; set; }         //Armazena a data de início do curso. O get permite que o valor seja
                                                                     //lido e o set permite que o valor seja alterado.


            [DisplayName("Validità a: ")]                            //Usado para definire o nome que será exibido na interface, facilitando o
                                                                     //entendimento para o usuário.
            public DateTime? DataValiditaFine { get; set; }          //Armazena a data de fim do curso. O get permite que o valor seja lido
                                                                     //e o set permite que o valor seja alterado.
        }
    }