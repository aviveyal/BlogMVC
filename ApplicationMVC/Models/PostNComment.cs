using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApplicationMVC.Models
{
	public class PostNComment : DbContext
	{
		public DbSet<Post> post { get; set; }
		public DbSet<Comment> comment { get; set; }

	}
}