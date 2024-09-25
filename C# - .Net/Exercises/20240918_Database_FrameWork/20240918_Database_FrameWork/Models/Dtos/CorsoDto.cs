using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240918_Database_FrameWork.Models.Dtos
{
    public class CorsoDto                                                                          //A classe é pública, o que significa que pode ser acessada de qualquer
                                                                                                   //outro código no projeto. A classe StudenteDto serve como um objeto de
                                                                                                   //transferência de dados para um estudante, facilitando a transferência
                                                                                                   //de informações de um lugar para outro, sem expor diretamente a
                                                                                                   //entidade do banco de dados.
    {
        public int Id { get; set; }                                                                //Identificador único do curso. O get permite que o valor seja lido e o
                                                                                                   //set permite que o valor seja alterado.
        public string Nome { get; set; }                                                           //Armazena o nome do curso. O get permite que o valor seja lido e o set
                                                                                                   //permite que o valor seja alterado.
        public DateTime DataValiditaInizio { get; set; }                                           //Armazena a data de início do curso. O get permite que o valor seja
                                                                                                   //lido e o set permite que o valor seja alterado.
        public DateTime? DataValiditaFine { get; set; }                                            //Armazena a data de fim do curso. O get permite que o valor seja lido
                                                                                                   //e o set permite que o valor seja alterado.
    }
}
