using System;

namespace _20241001_BusinessLayer.Models.Dtos
{
    public class StudenteDto                                                                       //A classe é pública, o que significa que pode ser acessada de qualquer
                                                                                                   //outro código no projeto. A classe StudenteDto serve como um objeto de
                                                                                                   //transferência de dados para um estudante, facilitando a transferência
                                                                                                   //de informações de um lugar para outro, sem expor diretamente a
                                                                                                   //entidade do banco de dados.
    {
        public int Id { get; set; }                                                            //Identificador único do estudante. O get permite que o valor seja lido
                                                                                               //e o set permite que o valor seja alterado.
        public string Nome { get; set; }                                                       //Armazena o nome do estudante. O get permite que o valor seja lido e o
                                                                                               //set permite que o valor seja alterado.
        public string Cognome { get; set; }                                                    //Armazena o sobrenome do estudante. O get permite que o valor seja lido
                                                                                               //e o set permite que o valor seja alterado.
        public string CodiceFiscale { get; set; }                                              //Representa o código fiscal do estudante. O get permite que o valor seja
                                                                                               //lido e o set permite que o valor seja alterado.
        public DateTime DataDiNascita { get; set; }                                            //Armazena a data de nascimento do estudante. O get permite que o valor
                                                                                               //seja lido, e o set permite que o valor seja alterado.
        public int CorsoId { get; set; }                                                       //Referencia o identificador do curso ao qual o estudante está vinculado.
                                                                                               //O get permite que o valor seja lido, e o set permite que o valor seja
                                                                                               //alterado.
    }
}
