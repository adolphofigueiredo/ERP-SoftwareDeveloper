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

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ClienteEntity>(t =>
            {

                t.HasKey(p => p.Id);

                t.Property(p => p.Id)
                .IsRequired();

                t.Property(p => p.Name)
                .HasMaxLength(250) .IsRequired();

                t.HasMany(p => p.Ordini)
                .WithOne(p => p.Cliente)
                .HasForeignKey(p => p.IdCliente);

            });

            base.OnModelCreating(modelBuilder);
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
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrdineClienteDettaglioEntity>(t =>
            {

                t.HasKey(p => p.Id);

                t.Property(p => p.Id)
                .IsRequired();

                t.HasOne(p => p.OrdineClienteTesta)
                .WithMany(p => p.Dettagli)
                .HasForeignKey(p => p.IdOrdineClienteTesta);

            });

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FornitoreEntity>(t =>
            {

                t.HasKey(p => p.Id);

                t.Property(p => p.Id)
                .IsRequired();

                t.Property(p => p.Name)
                .HasMaxLength(250).IsRequired();

                t.HasMany(p => p.Ordini)
                .WithOne(p => p.Fornitore)
                .HasForeignKey(p => p.IdFornitore );

            });

            base.OnModelCreating(modelBuilder);
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

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrdineFornitoreDettaglioEntity>(t =>
            {

                t.HasKey(p => p.Id);

                t.Property(p => p.Id)
                .IsRequired();

                t.HasOne(p => p.OrdineFornitoreTesta)
                .WithMany(p => p.Dettagli)
                .HasForeignKey(p => p.IdOrdineFornitoreTesta);

            });

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProdottoEntity>(t =>
            {

                t.HasKey(p => p.Id);

                t.Property(p => p.Id)
                .IsRequired();

            });

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MovimentoMagazzinoEntity>(t =>
            {

                t.HasKey(p => p.Id);

                t.Property(p => p.Id)
                .IsRequired();

            });
        }
    }
}