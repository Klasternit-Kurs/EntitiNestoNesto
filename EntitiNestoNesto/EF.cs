using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiNestoNesto
{
	public class EF : DbContext
	{
		public DbSet<Osoba> Osobas { get; set; }
		public DbSet<Adresa> Adresas { get; set; }

		public DbSet<Artikal> Artikals { get; set; }
		public DbSet<Racun> Racuns { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Osoba>().HasKey(o => o.Id);
			modelBuilder.Entity<Adresa>().HasKey(a => a.Id);

			modelBuilder.Entity<Racun>().HasKey(r => r.Rbr);
			modelBuilder.Entity<Artikal>().HasKey(a => a.Id);
		}

		public EF() : base(@"Data Source=DESKTOP-75VO5EN\TESTSERVER;Initial Catalog=NekaBaza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
		{ }

	}
}
