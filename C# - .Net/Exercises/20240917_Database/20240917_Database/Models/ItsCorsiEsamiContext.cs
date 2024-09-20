using _20240917_Database.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240917_Database.Models
{
    internal class ItsCorsiEsamiContext : DbContext
    {
        public DbSet<StudenteEntity> Studente { get; set; }

        public DbSet<CorsoEntity> Corso { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudenteEntity>()
                .ToTable("AnagraficheStudenti")
                .HasKey(t => t.Id);

            modelBuilder.Entity<StudenteEntity>()
                .Property(p => p.Id)
                .IsRequired()


            modelBuilder.Entity<StudenteEntity>()
                .Property(p => p.Cognome).HasMaxLength(50).IsRequired()
                
            modelBuilder.Entity<StudenteEntity>()
                .Property(p => p.Nome).HasMaxLength(50).IsRequired()

            modelBuilder.Entity<StudenteEntity>()
                .Property(p => p.CodiceFiscale).HasMaxLength(21).IsRequired()
                .HasColumnName("")

            modelBuilder.Entity<StudenteEntity>()
                .Property(p => p.DataDiNascita).IsRequired()

        }
    }
}
