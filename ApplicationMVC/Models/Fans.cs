using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicationMVC.Models
{
	public class Fans
	{
		public int ID { get; set; }
		public String Name { get; set; }
		public DateTime Birth { get; set; }
		public int Age { get; set; }
		public String Gender { get; set; }

	}

	public class FanDBcontext : System.Data.Entity.DbContext
	{
		public DbSet<Fans> Fans { get; set; }
	}

}