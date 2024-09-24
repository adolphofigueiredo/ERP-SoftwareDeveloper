using _20240918_Database_FrameWork.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace _20240918_Database_FrameWork.Models
{
    public class ItsCorsiEsamiContext : DbContext                                                  //A classe ItsCorsiEsamiContext herda de DbContext, que é a classe principal do Entity
                                                                                                   //Framework usada para interagir com o banco de dados. O DbContext encapsula todas as
                                                                                                   //operações de banco de dados, incluindo consultas e salvamento de dados.
    {
        public DbSet<StudenteEntity> Studenti { get; set; }
        public DbSet<CorsoEntity> Corsi { get; set; }                                              //O DbSet<StudenteEntity> e DbSet<CorsoEntity> são mapeadas para tabelas no banco de
                                                                                                   //dados. Cada DbSet representa uma coleção de entidades no banco. Essas entidades podem
                                                                                                   //ser consultadas (get), adicionadas, modificadas ou removidas da base de dados (set).
                                                                                                   //O DbSet<StudenteEntity> Studenti mapeia para uma tabela onde serão armazenados dados
                                                                                                   //de estudantes. O DbSet<CorsoEntity> Corsi mapeia para uma tabela onde serão
                                                                                                   //armazenados dados de cursos.

        public ItsCorsiEsamiContext(string connectionString) : base(connectionString)
        { 
        
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)                       //O método protected override está indica que esta implementação customizada irá
                                                                                                   //substituir ou complementar a original. O OnModelCreating(modelBuilder) chama a
                                                                                                   //implementação base do método para garantir que o comportamento padrão do Entity
                                                                                                   //Framework ainda seja aplicado. Isso é opcional, mas recomendado em casos onde
                                                                                                   //você deseja que o Entity Framework aplique as configurações padrão, além das
                                                                                                   //personalizações que você fará. O parâmetro modelBuilder é uma instância de
                                                                                                   //DbModelBuilder, que permite definir como as entidades (as classes C#) serão
                                                                                                   //mapeadas para as tabelas do banco de dados. O modelBuilder oferece uma interface
                                                                                                   //fluente para configurar coisas como o nome das tabelas, as chaves primárias, as
                                                                                                   //chaves estrangeiras e relações entre tabelas.
        {
            base.OnModelCreating(modelBuilder);                                                    //Essa linha chama a implementação base do método para garantir que o
                                                                                                   //comportamento padrão do EF ainda seja aplicado. Isso é opcional, mas recomendado
                                                                                                   //em casos onde você deseja que o EF aplique as configurações padrão, além das
                                                                                                   //personalizações que você fará.

            modelBuilder.Entity<StudenteEntity>()                                                  //O parâmetro modelBuilder é uma instância de DbModelBuilder, que permite definir
                                                                                                   //como as entidades (as classes C#) serão mapeadas para as tabelas do banco de
                                                                                                   //dados.

            .ToTable("AnagraficheStudenti")                                                        //O ToTable("AnagraficheStudenti"): Define que a entidade StudenteEntity será
                                                                                                   //mapeada para a tabela chamada "AnagraficheStudenti". Se não fosse configurada,
                                                                                                   //o Entity Framework criaria uma tabela com o nome padrão baseado na classe
                                                                                                   //(StudenteEntities).

            .HasKey(t => t.Id);                                                                    //Define que a propriedade Id será usada como a chave primária da tabela, crucial
                                                                                                   //para identificar registros de forma única.

            modelBuilder.Entity<StudenteEntity>()
            .Property(p => p.Id)                                                                   //Define que esta propriedade da entidade será configurada.
            .IsRequired();                                                                         //Torna essa propriedade obrigatória no banco de dados, ou seja, não pode ser nula.
            //AUTOINC

            modelBuilder.Entity<StudenteEntity>()
                .Property(p => p.Cognome)                                                          //Define que esta propriedade da entidade será configurada.
                .HasMaxLength(50)                                                                  //Define que o campo no banco de dados terá um comprimento máximo de 50 caracteres.
                .IsRequired();                                                                     //Torna essa propriedade obrigatória no banco de dados, ou seja, não pode ser nula.

            modelBuilder.Entity<StudenteEntity>()
                .Property(p => p.Nome)                                                             //Define que esta propriedade da entidade será configurada.
                .HasMaxLength(50)                                                                  //Define que o campo no banco de dados terá um comprimento máximo de 50 caracteres.
                .IsRequired();                                                                     //Torna essa propriedade obrigatória no banco de dados, ou seja, não pode ser nula.

            modelBuilder.Entity<StudenteEntity>()
                .Property(p => p.CodiceFiscale)                                                    //Define que esta propriedade da entidade será configurada.
                .HasColumnName("CF")                                                               //Este método especifica como a coluna correspondente à propriedade deve ser chamada
                .HasMaxLength(50)                                                                  //Define que o campo no banco de dados terá um comprimento máximo de 21 caracteres.
                .IsRequired();                                                                     //Torna essa propriedade obrigatória no banco de dados, ou seja, não pode ser nula.

            modelBuilder.Entity<StudenteEntity>()
                .Property(p => p.DataDiNascita)                                                    //Define que esta propriedade da entidade será configurada.
                .IsRequired();                                                                     //Torna essa propriedade obrigatória no banco de dados, ou seja, não pode ser nula.









            modelBuilder.Entity<StudenteEntity>()                                                  //RELAZIONI
                .HasRequired(p => p.Corso)
                .WithMany(p => p.Studenti)
                .HasForeignKey(p => p.CorsoId);
                            









            modelBuilder.Entity<CorsoEntity>()
                    .ToTable("AnagraficheCorsi")                                                   //O ToTable("AnagraficheCorsi"): Define que a entidade CorsiEntity será
                                                                                                   //mapeada para a tabela chamada "AnagraficheCorsi". Se não fosse configurada,
                                                                                                   //o Entity Framework criaria uma tabela com o nome padrão baseado na classe
                                                                                                   //(CorsoEntities).

                    .HasKey(t => t.Id);                                                            //Define que a propriedade Id será usada como a chave primária da tabela, crucial
                                                                                                   //para identificar registros de forma única.

            
            
            
            
            modelBuilder.Entity<CorsoEntity>()
                .Property(p => p.Id)                                                               //Define que esta propriedade da entidade será configurada.
                .IsRequired();                                                                     //Torna essa propriedade obrigatória no banco de dados, ou seja, não pode ser nula.
            //AUTOINC




            modelBuilder.Entity<CorsoEntity>()
                .Property(p => p.Nome)                                                             //Define que esta propriedade da entidade será configurada.
                .HasMaxLength(50)                                                                  //Define que o campo no banco de dados terá um comprimento máximo de 50 caracteres.
                .HasColumnName("NomeCorso");                                                       //Este método especifica como a coluna correspondente à propriedade deve ser chamada

            modelBuilder.Entity<CorsoEntity>()
                .Property(p => p.DataValiditaInizio)                                               //Define que esta propriedade da entidade será configurada.
                .IsRequired();                                                                     //Torna essa propriedade obrigatória no banco de dados, ou seja, não pode ser nula.

            modelBuilder.Entity<CorsoEntity>()
                .Property(p => p.DataValiditaFine);                                                //Define que esta propriedade da entidade será configurada.








            modelBuilder.Entity<CorsoEntity>()                                                     //RELAZIONI
                .HasMany(p => p.Studenti)
                .WithRequired(p => p.Corso)
                .HasForeignKey(p => p.CorsoId);

        }
    }
}
