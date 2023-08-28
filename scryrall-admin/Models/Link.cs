using System;
namespace scryrall_admin.Models
{
	public class Link
	{
		public int Id;
		public string Url;

		public virtual Carta Carta { get; set; }


        public Link()
		{
		}
	}
}

