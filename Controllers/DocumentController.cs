using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u20676736_HW03.Controllers
{
    public class DocumentController : Controller
    {
        // GET: Document
        public ActionResult Files()
        {
            return View();
        }
        public ActionResult Images()
        {
            return View();
        }
        public ActionResult Videos()
        {
            return View();
        }
        public ActionResult AboutMe()
        {

            return View();
        }
    }
}