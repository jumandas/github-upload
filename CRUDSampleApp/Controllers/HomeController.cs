using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CRUDSampleApp.Controllers
{
	public class HomeController : Controller
    {
		public ActionResult Index()
		{
			return View();
		}

		[NonAction]
		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";
			return View();
		}

		public ActionResult Contact()
		{
			UserLoginInfo
			ViewBag.Message = "Your contact page.";
			return View();
		}
	}
}