using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalFantasy14API.Web.Controllers
{
    public class HomeController : Controller
    {

        Func<string, string, bool> convertToUppderCase = (x, y) => x == y;


        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            string myString = "not capitalized";
            System.Diagnostics.Debug.WriteLine(convertToUppderCase(myString, "not capidtalized"));
            

            return View();
        }
    }
}
