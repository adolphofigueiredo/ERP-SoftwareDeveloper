using _20241001_BusinessLayer.Models.Entities;
using System.Data.Entity;

namespace _20241001_BusinessLayer.Models
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
        }                                                                                          //Esta linha é um construtor da classe ItsCorsiEsamiContext, lembrando que os construtores
                                                                                                   //são métodos especiais que são chamados automaticamente quando um objeto dessa classe é
                                                                                                   //instanciado. O public é um modificador de acesso, Isso significa que o construtor é
                                                                                                   //acessível de qualquer lugar onde o ItsCorsiEsamiContext for usado.

        //O string connectionString diz que o construtor aceita um parâmetro do tipo string, que
        //é a string de conexão do banco de dados. Isso permite que, ao criar uma nova instância
        //de ItsCorsiEsamiContext, o usuário possa fornecer a string de conexão que será usada
        //para conectar-se ao banco de dados. Já o base(connectionString) é a parte chamada de
        //inicialização da classe base. O ItsCorsiEsamiContext herda de DbContext, que faz
        //parte do Entity Framework. O base(connectionString) chama o construtor da classe
        //DbContext e passa a connectionString como argumento. O DbContext utiliza essa string
        //de conexão para gerenciar as interações com o banco de dados, como abrir conexões e
        //executar comandos SQL. Essencialmente, o DbContext precisa de uma string de conexão
        //para saber como se conectar ao banco de dados. E quando você usa : base(connectionString),
        //você está delegando essa responsabilidade para a classe DbContext. Como o bloco está
        //vazio { } significa que nenhuma lógica adicional é executada dentro do construtor da
        //classe ItsCorsiEsamiContext. O único trabalho desse construtor é chamar o construtor
        //da classe base (DbContext) e passar a string de conexão. Resumindo, este construtor
        //permite criar instâncias da classe ItsCorsiEsamiContext usando uma string de conexão
        //personalizada, que será passada para o DbContext. O DbContext utiliza essa string de
        //conexão para configurar o provedor de banco de dados, o servidor, o nome do banco de
        //dados, e outras opções necessárias para o acesso ao banco de dados.
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
                .HasMaxLength(21)                                                                  //Define que o campo no banco de dados terá um comprimento máximo de 21 caracteres.
                .IsRequired();                                                                     //Torna essa propriedade obrigatória no banco de dados, ou seja, não pode ser nula.

            modelBuilder.Entity<StudenteEntity>()
                .Property(p => p.DataDiNascita)                                                    //Define que esta propriedade da entidade será configurada.
                .IsRequired();                                                                     //Torna essa propriedade obrigatória no banco de dados, ou seja, não pode ser nula.

            modelBuilder.Entity<StudenteEntity>()                                                  //Ponto em que se cria a relação
                .HasRequired(p => p.Corso)                                                         //HasRequired especifica que a propriedade Corso na entidade StudenteEntity é
                                                                                                   //obrigatória. Isso significa que todo estudante (instância de StudenteEntity)
                                                                                                   //deve estar associado a um curso (instância de CorsoEntity). Já o p => p.Corso
                                                                                                   //é uma expressão lambda que indica qual propriedade de navegação(o curso)
                                                                                                   //está sendo configurada na entidade StudenteEntity. Aqui, p.Corso refere-se
                                                                                                   //à propriedade de navegação que conecta um estudante a seu curso.

                .WithMany(p => p.Studenti)                                                         //WithMany indica que a entidade CorsoEntity (curso) está associada a muitos
                                                                                                   //estudantes. Essa parte da configuração define a relação do lado inverso, ou
                                                                                                   //seja, do curso para os estudantes. Já o p => p.Studenti indica que na entidade
                                                                                                   //CorsoEntity, existe uma coleção chamada Studenti que armazena os estudantes
                                                                                                   //que estão associados a esse curso.

                .HasForeignKey(p => p.CorsoId);                                                    //HasForeignKey especifica que a chave estrangeira da relação entre
                                                                                                   //StudenteEntity e CorsoEntity é a propriedade CorsoId. Isso significa que o
                                                                                                   //ID do curso será armazenado na tabela de estudantes(StudenteEntity) como uma
                                                                                                   //chave estrangeira, apontando para a tabela de cursos(CorsoEntity). Já o
                                                                                                   //parâmetro p => p.CorsoId indica que a propriedade CorsoId na entidade
                                                                                                   //StudenteEntity é a foreign key que estabelece essa relação.

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

            modelBuilder.Entity<CorsoEntity>()                                                   //Ponto em que se cria a relação
                .HasMany(p => p.Studenti)                                                          //HasMany indica que a entidade CorsoEntity (curso) está associada a muitos estudantes.
                                                                                                   //Já o p => p.Studenti é uma expressão lambda que especifica que a entidade CorsoEntity
                                                                                                   //possui uma propriedade de navegação chamada Studenti, que é uma coleção(normalmente
                                                                                                   //uma lista) de StudenteEntity. Ou seja, um curso pode ter vários estudantes.

                .WithRequired(p => p.Corso)                                                        //O WithRequired define que a entidade relacionada (StudenteEntity) tem uma relação
                                                                                                   //obrigatória com CorsoEntity. Isso significa que cada estudante deve estar associado
                                                                                                   //a um curso. Já a expressão p => p.Corso especifica que a propriedade Corso em
                                                                                                   //StudenteEntity é a propriedade de navegação que aponta para o curso relacionado.
                                                                                                   //Ou seja, cada estudante pertence a exatamente um curso.

                .HasForeignKey(p => p.CorsoId);                                                    //O HasForeignKey especifica a chave estrangeira que será usada para representar
                                                                                                   //essa relação no banco de dados. Já o p => p.CorsoId define que a propriedade CorsoId
                                                                                                   //na entidade StudenteEntity será a chave estrangeira que faz referência à entidade
                                                                                                   //CorsoEntity. Isso indica que, para cada estudante, o campo CorsoId armazena o
                                                                                                   //identificador do curso ao qual ele está associado.
        }
    }
}