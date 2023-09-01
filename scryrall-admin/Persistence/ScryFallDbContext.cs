using System;
using scryrall_admin.Models;
using Microsoft.EntityFrameworkCore;
namespace scryrall_admin.Persistence
{
	public class ScryFallDbContext : DbContext
	{

        public ScryFallDbContext(DbContextOptions<ScryFallDbContext> options)
        : base(options)
        {

        }
        public DbSet<Carta> Cartas { get; set; }

		public DbSet<Colecao> Colecoes { get; set; }

		public DbSet<Link> Links { get; set; }

		public DbSet<RegrasEspeciais> RegrasEspeciais { get; set; }

		public DbSet<ToolBox> ToolBoxes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar relacionamentos um-para-um aqui

            modelBuilder.Entity<Carta>()
                .HasOne(c => c.Link)
                .WithOne(l => l.Carta)
                .HasForeignKey<Link>(l => l.Id);

            modelBuilder.Entity<Carta>()
                .HasOne(c => c.Ilustrador)
                .WithOne(i => i.Carta)
                .HasForeignKey<Ilustrador>(i => i.Id);

            modelBuilder.Entity<Carta>()
                .HasOne(c => c.Colecao)
                .WithOne(co => co.Carta)
                .HasForeignKey<Colecao>(co => co.Id);

            // Resto das configurações de modelo

            base.OnModelCreating(modelBuilder);
        }





    }
}

    