using System;
namespace scryrall_admin.Models
{
	public class ToolBox
	{
		public int Id { get; set; }
		public string nome { get; set; }


		public virtual Carta Carta { get; set; }

        public ToolBox()
		{
		}
	}
}

