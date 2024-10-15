using BibliotecaWebService.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaWebService.Models
{
	public class GestioneBibliotecaContext : DbContext
	{
		// tabelle del DB
		public DbSet<LibroEntity> Libri { get; set; }
		public DbSet<ClienteEntity> Clienti { get; set; }
		public DbSet<PrestitoEntity> Prestiti { get; set; }

		public GestioneBibliotecaContext(DbContextOptions<GestioneBibliotecaContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// definizione struttura tabella 'Libro' nel database
			modelBuilder.Entity<LibroEntity>(t =>
			{
				// chiave primaria
				t.HasKey(p => p.ISBN);

				// definizione proprietà
				t.Property(p => p.ISBN)
				.HasMaxLength(50).IsRequired();

				t.Property(p => p.Titolo)
				.HasMaxLength(250).IsRequired();

				t.Property(p => p.Autori)
				.HasMaxLength(500);

				// definizione relazioni
				t.HasMany(p => p.Prestiti)
				.WithOne(p => p.Libro)
				.HasForeignKey(p => p.ISBN);
			});

			// definizione struttura tabella 'Cliente' nel database
			modelBuilder.Entity<ClienteEntity>(t =>
			{
				// chiave primaria
				t.HasKey(p => p.CodiceFiscale);

				// definizione proprietà
				t.Property(p => p.CodiceFiscale)
				.HasMaxLength(20).IsRequired();

				t.Property(p => p.Nome)
				.HasMaxLength(50).IsRequired();

				t.Property(p => p.Cognome)
				.HasMaxLength(50);

				// definizione relazioni
				t.HasMany(p => p.Prestiti)
				.WithOne(p => p.Cliente)
				.HasForeignKey(p => p.CodiceFiscale);
			});

			// definizione struttura tabella 'Prestito' nel database
			modelBuilder.Entity<PrestitoEntity>(t =>
			{
				// chiave primaria a cmapi multipli,
				// non è possibile inserire un cliente con lo stesso libro nella stessa data
				t.HasKey(p => new { p.CodiceFiscale, p.ISBN, p.DataInizio });

				// definizione proprietà
				t.Property(p => p.CodiceFiscale)
				.HasMaxLength(20).IsRequired();

				t.Property(p => p.ISBN)
				.HasMaxLength(50).IsRequired();

				t.Property(p => p.DataInizio)
				.IsRequired();

				// definizione relazioni
				t.HasOne(p => p.Cliente)
				.WithMany(p => p.Prestiti)
				.HasForeignKey(p => p.CodiceFiscale);

				t.HasOne(p => p.Libro)
				.WithMany(p => p.Prestiti)
				.HasForeignKey(p => p.ISBN);
			});
		}


	}
}
