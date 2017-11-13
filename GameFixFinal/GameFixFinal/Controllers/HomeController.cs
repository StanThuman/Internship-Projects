using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using GameFixFinal.Src;
using GameFixFinal.Models;
namespace GameFixFinal.Controllers
{
    public class HomeController : Controller
    {
        GameLibraryContext db = new GameLibraryContext();

        delegate void myDel();
        public ActionResult Index()
        {


            myDel myDelObject = () => Console.WriteLine("ldsjfld");

            bool ifExists = RenderPartialView.LoadPartial(this.ControllerContext, "_ImageSliderIndex");

            ViewBag.indexPartialView = ifExists;
            myDelObject();
            return View();
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

        public ActionResult Search(string search)
        {
            IQueryable<GameLibrary> searchGameLibrary = db.GameLibraries.Include(g => g.Developer).Include(g => g.Genre).Where(g => g.Title.Contains(search));
            
            
            return View();
        }

    

        public ActionResult Help()
        {
            return View();        
        }
    }
}