using _20241024_GestioneMagazzino.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _20241024_GestioneMagazzino.Models
{
    public class GestioneMagazzinoContext : DbContext
    {
        public DbSet<ClienteEntity> Clienti { get; set; }
        public DbSet<OrdineClienteTestaEntity> OrdineClienteTeste { get; set; }
        public DbSet<OrdineClienteDettaglioEntity> OrdineClienteDettagli { get; set; }
        public DbSet<FornitoreEntity> Fornitori { get; set; }
        public DbSet<OrdineFornitoreTestaEntity> OrdineFornitoreTeste { get; set; }
        public DbSet<OrdineFornitoreDettaglioEntity> OrdineFornitoreDettagli { get; set; }
        public DbSet<ProdottoEntity> Prodotti { get; set; }
        public DbSet<MovimentoMagazzinoEntity> Movimenti { get; set; }

        public GestioneMagazzinoContext(DbContextOptions<GestioneMagazzinoContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração da entidade ClienteEntity
            modelBuilder.Entity<ClienteEntity>(t =>
            {
                t.HasKey(p => p.Id);

                t.Property(p => p.Id)
                    .IsRequired();

                t.Property(p => p.Nome)
                    .HasMaxLength(250)
                    .IsRequired();

                t.HasMany(p => p.Ordini)
                    .WithOne(p => p.Cliente)
                    .HasForeignKey(p => p.IdCliente);
            });

            // Configuração da entidade OrdineClienteTestaEntity
            modelBuilder.Entity<OrdineClienteTestaEntity>(t =>
            {
                t.HasKey(p => p.Id);

                t.Property(p => p.Id)
                    .IsRequired();

                t.Property(p => p.Data)
                    .IsRequired();

                t.HasOne(p => p.Cliente)
                    .WithMany(p => p.Ordini)
                    .HasForeignKey(p => p.IdCliente);

                t.HasMany(p => p.Dettagli)
                    .WithOne(p => p.OrdineClienteTesta)
                    .HasForeignKey(p => p.IdOrdineClienteTesta);
            });

            // Configuração da entidade OrdineClienteDettaglioEntity
            modelBuilder.Entity<OrdineClienteDettaglioEntity>(t =>
            {
                t.HasKey(p => p.Id);

                t.Property(p => p.Id)
                    .IsRequired();

                t.HasOne(p => p.OrdineClienteTesta)
                    .WithMany(p => p.Dettagli)
                    .HasForeignKey(p => p.IdOrdineClienteTesta);

                t.HasOne(p => p.Prodotto)
                    .WithMany() // Se Prodotto não possui coleção de detalhes, deixe vazio
                    .HasForeignKey(p => p.IdProdotto);
            });

            // Configuração da entidade FornitoreEntity
            modelBuilder.Entity<FornitoreEntity>(t =>
            {
                t.HasKey(p => p.Id);

                t.Property(p => p.Id)
                    .IsRequired();

                t.Property(p => p.Nome)
                    .HasMaxLength(250)
                    .IsRequired();

                t.HasMany(p => p.Ordini)
                    .WithOne(p => p.Fornitore)
                    .HasForeignKey(p => p.IdFornitore);
            });

            // Configuração da entidade OrdineFornitoreTestaEntity
            modelBuilder.Entity<OrdineFornitoreTestaEntity>(t =>
            {
                t.HasKey(p => p.Id);

                t.Property(p => p.Id)
                    .IsRequired();

                t.Property(p => p.Data)
                    .IsRequired();

                t.HasOne(p => p.Fornitore)
                    .WithMany(p => p.Ordini)
                    .HasForeignKey(p => p.IdFornitore);

                t.HasMany(p => p.Dettagli)
                    .WithOne(p => p.OrdineFornitoreTesta)
                    .HasForeignKey(p => p.IdOrdineFornitoreTesta);
            });

            // Configuração da entidade OrdineFornitoreDettaglioEntity
            modelBuilder.Entity<OrdineFornitoreDettaglioEntity>(t =>
            {
                t.HasKey(p => p.Id);

                t.Property(p => p.Id)
                    .IsRequired();

                t.HasOne(p => p.OrdineFornitoreTesta)
                    .WithMany(p => p.Dettagli)
                    .HasForeignKey(p => p.IdOrdineFornitoreTesta);

                t.HasOne(p => p.Prodotto)
                    .WithMany()
                    .HasForeignKey(p => p.IdProdotto);
            });

            // Configuração da entidade ProdottoEntity
            modelBuilder.Entity<ProdottoEntity>(t =>
            {
                t.HasKey(p => p.Id);

                t.Property(p => p.Id)
                    .IsRequired();
            });

            // Configuração da entidade MovimentoMagazzinoEntity
            modelBuilder.Entity<MovimentoMagazzinoEntity>(t =>
            {
                t.HasKey(p => p.Id);

                t.Property(p => p.Id)
                    .IsRequired();

                t.HasOne(p => p.OrdineClienteDettaglio)
                    .WithMany()
                    .HasForeignKey(p => p.IdOrdineClienteDettaglio)
                    .OnDelete(DeleteBehavior.NoAction);

                t.HasOne(p => p.OrdineFornitoreDettaglio)
                    .WithMany()
                    .HasForeignKey(p => p.IdOrdineFornitoreDettaglio)
                    .OnDelete(DeleteBehavior.NoAction);

                t.HasOne(p => p.Prodotto)
                    .WithMany()
                    .HasForeignKey(p => p.IdProdotto)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            // Chamando base.OnModelCreating uma única vez
            base.OnModelCreating(modelBuilder);
        }
    }
}
