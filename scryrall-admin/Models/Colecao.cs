using System;
namespace scryrall_admin.Models
{
	public class Colecao
	{
		public int Id { get; set; }
		public string Nome { get; set; }
        public DateTime Ano { get; set; }
        public string LogoUrl { get; set; }

		public virtual Carta Carta { get; set; }



        public Colecao()
		{
		}
	}
}

