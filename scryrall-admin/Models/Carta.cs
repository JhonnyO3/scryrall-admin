using scryrall_admin.NovaPasta1;
using System;
using System.ComponentModel.DataAnnotations;

namespace scryrall_admin.Models
{
	public class Carta
	{
		public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }

		[Required]
		[DataType(DataType.ImageUrl)]
		[Display(Name = "Url Foto")]
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
        public Carta(EditDto editDto)
        {
			Tipo = editDto.Tipo;
			Descricao = editDto.Descricao;
			Link.Url = editDto.Url;

        }
    }
}

