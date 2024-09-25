using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace _20240918_Database_FrameWork.Models.Entity                                               //Dentro do namespace _20240918_Database_FrameWork.Models.Entity existe a
                                                                                                   //classe StudenteEntie do projeto que fica dentro da pasta Models.Entity.
                                                                                                   //Isso indica que a classe faz parte das entidades que representam os dados
                                                                                                   //do modelo de domínio do projeto.
{
    public class StudenteEntity                                                                    //A public class StudenteEntity é uma classe pública que representa um
                                                                                                   //"estudante" no contexto da aplicação. O nome StudenteEntity segue a
                                                                                                   //convenção de design de Entity Framework, onde cada classe de entidade
                                                                                                   //corresponde a uma tabela no banco de dados.
    {
        public int Id { get; set; }                                                                //Representa um identificador do tipo inteiro único do estudante. Em um
                                                                                                   //contexto de banco de dados, essa propriedade geralmente é a chave
                                                                                                   //primária da tabela. O get permite que o valor seja lido, e o set permite
                                                                                                   //que o valor seja alterado.
        public string Nome { get; set; }                                                           //Representa o Nome do estudante, do tipo string. O get permite que o
                                                                                                   //valor seja lido, e o set permite que o valor seja alterado.
        public string Cognome { get; set; }                                                        //Representa o Cognome do estudante, do tipo string. O get permite que o
                                                                                                   //valor seja lido, e o set permite que o valor seja alterado.
        public string CodiceFiscale { get; set; }                                                  //Representa o Codice Fiscale do estudante, do tipo string. O get permite
                                                                                                   //que o valor seja lido, e o set permite que o valor seja alterado.
        public DateTime DataDiNascita { get; set; }                                                //Representa a data de nascimento do estudante, do tipo DateTime. O get
                                                                                                   //permite que o valor seja lido, e o set permite que o valor seja alterado.
        public int CorsoId { get; set; }                                                           //Representa um identificador, do tipo inteiro, único dos cursos. Em um
                                                                                                   //contexto de banco de dados, essa propriedade geralmente é a chave
                                                                                                   //primária da tabela. Neste caso este campo atua como a chave estrangeira
                                                                                                   //que faz a ligação com a entidade CorsoEntity. O get permite que o valor
                                                                                                   //seja lido, e o set permite que o valor seja alterado.
        public virtual CorsoEntity Corso { get; set; }                                             //O modificador de acesso public significa que essa propriedade é acessível
                                                                                                   //de qualquer lugar no código. Isso significa que qualquer código pode
                                                                                                   //acessar e modificar essa propriedade. A palavra-chave virtual indica diz
                                                                                                   //que a propriedade pode ser sobrescrita em uma classe derivada. No contexto
                                                                                                   //do Entity Framework, essa palavra-chave também habilita a carregamento
                                                                                                   //lento (lazy loading). No caso de lazy loading, o Entity Framework só
                                                                                                   //carrega os dados relacionados(a entidade Corso) quando você realmente
                                                                                                   //acessa essa propriedade pela primeira vez, e não quando a entidade
                                                                                                   //StudenteEntity é carregada pela primeira vez. O get permite que o valor
                                                                                                   //seja lido, e o set permite que o valor seja alterado.
    }
}
