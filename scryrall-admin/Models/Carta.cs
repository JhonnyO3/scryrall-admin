using System;
namespace scryrall_admin.Models
{
	public class Carta
	{
		public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string FotoUrl { get; set; }

        public virtual Link Link { get; set; }
		public virtual Ilustrador Ilustrador { get; set; }
		public virtual Colecao Colecao { get; set; }
		public virtual ICollection<Idioma> Idiomas { get; set; }
		public virtual ICollection<RegrasEspeciais> RegrasEspeciais { get; set; }
		public virtual ICollection<ToolBox> ToolBoxes { get; set; }



        public Carta()
		{
		}
	}
}

