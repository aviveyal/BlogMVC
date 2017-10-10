using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApplicationMVC.Models;
using System.Data.Entity;

namespace ApplicationMVC.Controllers
{
	
	public class HomeController : Controller
	{
		private PostNComment db = new PostNComment();
		public ActionResult Index()
		{

			var viewmodel = new ViewModel();
			viewmodel.Posts = db.post.ToList();
			viewmodel.Comments = db.comment.ToList();

			return View(viewmodel);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}