using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.IO;
using u20676736_HW03.Models;

namespace u20676736_HW03.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
            public ActionResult Files()
        {
            string[] filePaths = Directory.GetFiles(Server.MapPath("~/App_Data/uploads/"));

            List<FileModel> files = new List<FileModel>();
            foreach (string filePath in filePaths)

            {
                files.Add(new FileModel

                {
                    FileName = Path.GetFileName(filePath).ToString()
                }) ;

            }
            return View(files);
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