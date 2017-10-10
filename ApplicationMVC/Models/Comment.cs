using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ApplicationMVC.Models
{
	public class Comment
	{
		public int CommentID { get; set; }
		public int PostID { get; set; }
		[Required(ErrorMessage = "This field can not be empty.")]
		public string Title { get; set; }
		[Required(ErrorMessage = "This field can not be empty.")]
		public String AuthorName { get; set; }
		[Required(ErrorMessage = "This field can not be empty.")]
		public String Site { get; set; }
		[Required(ErrorMessage = "This field can not be empty.")]
		public string Body { get; set; }
		public Post post { get; set; }

	}
}