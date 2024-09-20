using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbExplorer_WinApp.Models.Entities;

namespace DbExplorer_WinApp.Models
{
    public class ItsCorsiEsamiContext : DbContext
    {
        public DbSet<StudenteEntity> Studenti { get; set; }
        public DbSet<CorsoEntity> Corsi { get; set; }

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

        }
    }
}
