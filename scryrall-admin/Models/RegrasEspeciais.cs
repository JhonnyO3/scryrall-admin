using System;
namespace scryrall_admin.Models
{
	public class RegrasEspeciais
	{
		public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }


        public virtual Carta Carta { get; set; }

        public RegrasEspeciais()
		{
		}
	}
}

