﻿using GameFixFinal.Src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameFixFinal.Controllers
{
    public class SonyController : Controller
    {
        //
        // GET: /Sony/
        public ActionResult Index()
        {
            bool ifExists = RenderPartialView.LoadPartial(this.ControllerContext, "_ImageSliderIndex");

            ViewBag.indexPartialView = ifExists;
            return View();
        }
	}
}