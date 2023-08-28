using System;
namespace scryrall_admin.Models
{
	public class Ilustrador
	{
		public int Id { get; set; }
        public string Nome { get; set; }

		public virtual Carta Carta { get; set; }



        public Ilustrador()
		{
		}
	}
}

