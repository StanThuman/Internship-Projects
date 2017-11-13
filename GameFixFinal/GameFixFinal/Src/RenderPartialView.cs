using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameFixFinal.Src
{
    public class RenderPartialView
    {
        public static bool LoadPartial(ControllerContext context, string partialViewName)
        {
            ViewEngineResult result = ViewEngines.Engines.FindPartialView(context, partialViewName);
            bool ifExists = (result != null) ? true : false;         
            
            return (ifExists);
        }
    }
}