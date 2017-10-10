using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApplicationMVC.Models
{
	public class Post
	{
		private DateTime? currentTime;
		public int PostID { get; set; }
		[Required(ErrorMessage = "This field can not be empty.")]
		public String Title { get; set; }
		[Required(ErrorMessage = "This field can not be empty.")]
		public String AuthorName { get; set; }
		[Required(ErrorMessage = "This field can not be empty.")]
		public String SiteAddress { get; set; }
		[Required(ErrorMessage = "This field can not be empty.")]
		public DateTime PublishDate
		{
			get { return currentTime ?? DateTime.Now; }
			set { currentTime = value; }
		}
		[Required(ErrorMessage = "This field can not be empty.")]
		public String Body { get; set; }
		public String image { get; set; }
		public String video { get; set; }
		public ICollection<Comment> Comments { get; set; }

		}
	
	

}