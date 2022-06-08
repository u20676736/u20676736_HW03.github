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
    public class VideoController : Controller
    {
        // GET: Video
        public ActionResult Videos()
        {
            string[] filePaths = Directory.GetFiles(Server.MapPath("~/App_Data/uploads/"));

            List<FileModel> files = new List<FileModel>();

            foreach (string filemodel in filePaths)
            {
                files.Add(new FileModel { FileName = Path.GetFileName(filemodel) });
            }
            return View(files);
        }

        public FileResult DownloadFile(string fileName) 
        {
            string path = Server.MapPath("~/App_Data/uploads/") + fileName;
                        
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            

            return File(bytes, "application/octet-stream", fileName);
        }

        public ActionResult DeleteFile(string fileName)
        {            

            string path = Server.MapPath("~/App_Data/uploads/") + fileName;
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            System.IO.File.Delete(path);

            return RedirectToAction("Index");
        }
    }
}
