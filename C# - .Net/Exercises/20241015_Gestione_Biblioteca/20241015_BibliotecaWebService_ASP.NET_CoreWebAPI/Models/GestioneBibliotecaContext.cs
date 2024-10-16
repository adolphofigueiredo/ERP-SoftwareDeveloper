using _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BibliotecaWebService.Models
{
    public class GestioneBibliotecaContext : DbContext               //Esta classe é responsável por gerenciar a conexão e interações com o banco de dados. A
                                                                     //classe herda de DbContext, fornecendo funcionalidades como consultas, inserções e
                                                                     //alterações nos dados.
    {
        //Tabelas do Banco de Dados
        public DbSet<LibroEntity> Libri { get; set; }                //Define e mapeia as tabelas do banco de dados. Cada DbSet representa uma coleção de
        public DbSet<ClienteEntity> Clienti { get; set; }            //objetos/entidades que correspondem a linhas na tabela de banco de dados. No caso,
        public DbSet<PrestitoEntity> Prestiti { get; set; }          //temos três tabelas: Libri, Clienti e Prestiti.

        public GestioneBibliotecaContext(DbContextOptions<GestioneBibliotecaContext> options) : base(options)
                                                                     //Quando você cria uma nova instância do GestioneBibliotecaContext, o construtor precisa
                                                                     //de options, que contém todas as configurações necessárias para a conexão com o banco de
                                                                     //dados. O base(options) garante que essas opções sejam enviadas para a classe DbContext,
                                                                     //que é a classe que realmente se conecta ao banco de dados e gerencia as operações de
                                                                     //leitura e escrita.
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
                                                                     //O método override Indica que este método está substituindo (ou "sobrescrevendo") um método
                                                                     //da classe base, que no caso é o DbContext (classe do Entity Framework). O método
                                                                     //OnModelCreating já existe na classe DbContext, mas aqui ele está sendo personalizando para
                                                                     //configurar as entidades desta aplicação. O OnModelCreating(ModelBuilder modelBuilder) é o
                                                                     //nome do método(OnModelCreating) e ele aceita um parâmetro chamado modelBuilder. O
                                                                     //ModelBuilder é uma classe fornecida pelo Entity Framework que se usa para configurar o
                                                                     //mapeamento das entidades(classes) para as tabelas do banco de dados. É onde se define
                                                                     //como as classes do código(por exemplo, LibroEntity, ClienteEntity, PrestitoEntity) vão
                                                                     //se relacionar com as tabelas no banco de dados, quais são as chaves primárias, tamanhos
                                                                     //máximos de campos, relações entre tabelas, etc.
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LibroEntity>(t =>                    //Definição da estrutura da tabella 'Libro' no banco de dados.
            {
                t.HasKey(p => p.ISBN);                               //Definição da chave primaria.

                t.Property(p => p.ISBN)                              //Definição da propriedade.
                .HasMaxLength(50).IsRequired();                      //Definição do tamanho maximo e da obrigatoriedade do campo.

                t.Property(p => p.Titolo)                            //Definição da propriedade.
                .HasMaxLength(250).IsRequired();                     //Definição do tamanho maximo e da obrigatoriedade do campo.

                t.Property(p => p.Autori)                            //Definição da propriedade.
                .HasMaxLength(500);                                  //Definição do tamanho maximo do campo.

                                                                     //Definição das relaçoes.
                t.HasMany(p => p.Prestiti)                           //Repare que aqui esta sendo dito que um livro pode ter muitos emprestimos e a contra
                .WithOne(p => p.Libro)                               //parte esta na entidade prestito.
                .HasForeignKey(p => p.ISBN);                         //Definição da chave que sera exportada e usada na entidade prestito.
            });

            modelBuilder.Entity<ClienteEntity>(t =>                  //Definição da estrutura da tabella 'Cliente' no banco de dados.
            {
                t.HasKey(p => p.CodiceFiscale);                      //Definição da chave primaria.

                t.Property(p => p.CodiceFiscale)                     //Definição da propriedade.
                .HasMaxLength(20).IsRequired();                      //Definição do tamanho maximo e da obrigatoriedade do campo.

                t.Property(p => p.Nome)                              //Definição da propriedade.
                .HasMaxLength(50).IsRequired();                      //Definição do tamanho maximo e da obrigatoriedade do campo.

                t.Property(p => p.Cognome)                           //Definição da propriedade.
                .HasMaxLength(50);                                   //Definição do tamanho maximo do campo.

                                                                     //Definição das relaçoes.
                t.HasMany(p => p.Prestiti)                           //Repare que aqui esta sendo dito que um cliente pode ter muitos emprestimos e a contra
                .WithOne(p => p.Cliente)                             //parte esta na entidade prestito.
                .HasForeignKey(p => p.CodiceFiscale);                //Definição da chave que sera exportada e usada na entidade prestito.
            });

            modelBuilder.Entity<PrestitoEntity>(t =>                 //Definição da estrutura da tabella 'Prestito' no banco de dados.
            {
                t.HasKey(p => new { p.CodiceFiscale, p.ISBN, p.DataInizio });
                                                                     //Definição da chave primaria com campos multiplos e assim evitando
                                                                     //que seja inserido um emprestimo de um mesmo livro para o mesmo
                                                                     //cliente no mesmo dia.
                t.Property(p => p.CodiceFiscale)                     //Definição da propriedade.
                .HasMaxLength(20).IsRequired();                      //Definição do tamanho maximo e da obrigatoriedade do campo.

                t.Property(p => p.ISBN)                              //Definição da propriedade.
                .HasMaxLength(50).IsRequired();                      //Definição do tamanho maximo e da obrigatoriedade do campo.

                t.Property(p => p.DataInizio)                        //Definição da propriedade.
                .IsRequired();                                       //Definição da obrigatoriedade do campo.

                                                                     //Definição das relaçoes.
                t.HasOne(p => p.Cliente)                             //Repare que aqui esta sendo dito que um cliente pode ter muitos emprestimos e a contra
                .WithMany(p => p.Prestiti)                           //parte esta na entidade cliente.
                .HasForeignKey(p => p.CodiceFiscale);                //Definição da chave que sera "importada" da entidade cliente.

                t.HasOne(p => p.Libro)                               //Repare que aqui esta sendo dito que um livro pode ter muitos emprestimos e a contra
                .WithMany(p => p.Prestiti)                           //parte esta na entidade libro.
                .HasForeignKey(p => p.ISBN);                         //Definição da chave que sera "importada" da entidade libro.
            });
        }
    }
}