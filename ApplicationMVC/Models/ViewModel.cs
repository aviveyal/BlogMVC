using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicationMVC.Models
{
	public class ViewModel
	{
		public IEnumerable<Post> Posts { get; set; }
		public IEnumerable<Comment> Comments { get; set; }

		public Comment Comment { get; set; }
		public Post Post { get; set; }
	}
}