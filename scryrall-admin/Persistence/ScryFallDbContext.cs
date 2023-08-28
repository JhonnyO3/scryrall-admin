using System;
using scryrall_admin.Models;
using Microsoft.EntityFrameworkCore;
namespace scryrall_admin.Persistence
{
	public class ScryFallDbContext : DbContext
	{
		public DbSet<Carta> Cartas { get; set; }

		public DbSet<Colecao> Colecoes { get; set; }

		public DbSet<Link> Links { get; set; }

		public DbSet<RegrasEspeciais> RegrasEspeciais { get; set; }

		public DbSet<ToolBox> ToolBoxes { get; set; }





        public ScryFallDbContext()
		{
		}
	}
}

