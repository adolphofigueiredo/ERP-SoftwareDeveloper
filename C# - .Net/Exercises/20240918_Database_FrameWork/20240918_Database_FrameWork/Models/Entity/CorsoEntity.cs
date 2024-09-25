using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240918_Database_FrameWork.Models.Entity
{
    public class CorsoEntity                                                                       //O class é usada para definir uma classe. A classe CorsoEntity representa
                                                                                                   //uma entidade no contexto de um banco de dados, que modela um curso. Ela
                                                                                                   //é usada para definir as propriedades e os relacionamentos de um curso,
                                                                                                   //como o nome, as datas de validade, e os estudantes associados. Esse tipo
                                                                                                   //de classe é comum em aplicações que usam ORM (Mapeamento Objeto-Relacional),
                                                                                                   //como o Entity Framework, para mapear classes C# para tabelas de banco de dados.
    {
        public CorsoEntity()                                                                       //O public CorsoEntity() é um construtor, que é um método chamado quando uma
                                                                                                   //nova instância de CorsoEntity é criada. No construtor, a propriedade Studenti
                                                                                                   //é inicializada como um HashSet<StudenteEntity>.
        { 
            Studenti = new HashSet<StudenteEntity>();                                              //A propriedade Studenti está sendo inicializada como um HashSet<StudenteEntity>.
                                                                                                   //Isso é uma boa prática para evitar que a coleção seja nula quando for acessada.
                                                                                                   //HashSet<T> é uma coleção que não permite valores duplicados e oferece operações
                                                                                                   //rápidas de busca e inserção, o que é eficiente para gerenciar relacionamentos
                                                                                                   //muitos-para-um.
        }
        public int Id { get; set; }                                                                //Representa um identificador do tipo inteiro único de cada curso. Em um
                                                                                                   //contexto de banco de dados, essa propriedade geralmente é a chave
                                                                                                   //primária da tabela. O get permite que o valor seja lido, e o set permite
                                                                                                   //que o valor seja alterado.
        public string Nome { get; set; }                                                           //Representa o Nome do curso, do tipo string. O get permite que o
                                                                                                   //valor seja lido, e o set permite que o valor seja alterado.
        public DateTime DataValiditaInizio { get; set; }                                           //Representa quando o curso começa a ser válido. O tipo DateTime é usado para
                                                                                                   //armazenar data e hora. O get permite que o valor seja lido, e o set permite
                                                                                                   //que o valor seja alterado.
        public DateTime? DataValiditaFine { get; set; }                                            //Representa quando o curso deixa de ser válido. O tipo DateTime é usado para
                                                                                                   //armazenar data e hora. O get permite que o valor seja lido, e o set permite
                                                                                                   //que o valor seja alterado.
        public virtual ICollection<StudenteEntity> Studenti { get; set; }                          //O Studenti define o relacionamento entre CorsoEntity e StudenteEntity, onde
                                                                                                   //um curso pode ter muitos estudantes. O uso do modificador virtual permite
                                                                                                   //que o Entity Framework implemente o lazy loading, o que significa que a
                                                                                                   //coleção de estudantes não será carregada até que seja explicitamente acessada.
                                                                                                   //Isso melhora a performance em alguns cenários. O ICollection é usada porque é
                                                                                                   //uma interface genérica que permite tanto leitura quanto modificação da coleção
                                                                                                   //de estudantes. O HashSet<T> inicializado no construtor é uma implementação de
                                                                                                   //ICollection, que garante que os estudantes não sejam duplicados dentro da coleção.
    }
}
