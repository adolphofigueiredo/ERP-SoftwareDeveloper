using System.Data.Entity;
using BusinessLayer.Models.Entities;

namespace BusinessLayer.Models
{
    public class ItsCorsiEsamiContext : DbContext
    {
        public DbSet<StudenteEntity> Studenti { get; set; }
        public DbSet<CorsoEntity> Corsi { get; set; }

        public ItsCorsiEsamiContext(string connectionString) : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudenteEntity>()
                .ToTable("AnagraficheStudenti")
                .HasKey(t => t.Id);

            modelBuilder.Entity<StudenteEntity>()
                .Property(p => p.Id)
                .IsRequired();
            // AUTOINC

            modelBuilder.Entity<StudenteEntity>()
                .Property(p => p.Cognome)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<StudenteEntity>()
               .Property(p => p.Nome)
               .HasMaxLength(50)
               .IsRequired();

            modelBuilder.Entity<StudenteEntity>()
               .Property(p => p.CodiceFiscale)
               .HasColumnName("Cf")
               .HasMaxLength(21)
               .IsRequired();

            modelBuilder.Entity<StudenteEntity>()
               .Property(p => p.DataDiNascita)
               .IsRequired();

            // RELAZIONI

            modelBuilder.Entity<StudenteEntity>()
                .HasRequired(p => p.Corso)
                .WithMany(p => p.Studenti)
                .HasForeignKey(p => p.CorsoId);


            modelBuilder.Entity<CorsoEntity>()
                .ToTable("AnagraficheCorsi")
                .HasKey(t => t.Id);

            modelBuilder.Entity<CorsoEntity>()
                .Property(p => p.Id)
                .IsRequired();
            // AUTOINC

            modelBuilder.Entity<CorsoEntity>()
                .Property(p => p.Nome)
                .HasMaxLength(50)
                .HasColumnName("NomeCorso");

            modelBuilder.Entity<CorsoEntity>()
               .Property(p => p.DataValiditaInizio)
               .IsRequired();

            modelBuilder.Entity<CorsoEntity>()
               .Property(p => p.DataValiditaFine);

            // RELAZIONI

            modelBuilder.Entity<CorsoEntity>()
                .HasMany(p => p.Studenti)
                .WithRequired(p => p.Corso)
                .HasForeignKey(p => p.CorsoId);

        }
    }
}
