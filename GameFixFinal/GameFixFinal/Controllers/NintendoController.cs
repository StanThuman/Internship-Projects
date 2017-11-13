using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using GameFixFinal.Models;
using GameFixFinal.Src;

namespace GameFixFinal.Controllers
{
    public class NintendoController : Controller
    {

        private GameLibraryContext db = new GameLibraryContext();
        
        //
        // GET: /Nintendo/
        public ActionResult Index()
        {
            bool ifExists = RenderPartialView.LoadPartial(this.ControllerContext, "_ImageSliderIndex");
            ViewBag.indexPartialView = ifExists;

            return View();
        }
        
        public ActionResult News()
        {
            return View();
        }

        public ActionResult Upcoming()
        {
            return View();
        }

        public ActionResult Browse()
        {
            //IEnumerable<GameLibrary> gameLibraries = db.GameLibraries.Include(g => g.Developer).Include(g => g.Genre);
            //gameLibraries = gameLibraries.OrderBy(g => g.Year);

            IEnumerable<GameLibrary> nintendoLibrary = db.GameLibraries.Include(g => g.Developer).Include(g => g.Genre)
                                                            .Where(g => g.Console.Contains("Nintendo"));      


            return View(nintendoLibrary.ToList());
        }



	}
}