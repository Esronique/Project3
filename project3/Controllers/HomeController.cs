using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace project3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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


        //[HttpPost]

        //public ActionResult UploadFile(HttpPostedFileBase file)
        //{
        //try
        //{
        //    if (file.ContentLength > 0)
        //    {
        //        string filename = Path.GetFileName(file.FileName);
        //        string filepath = Path.Combine(Server.MapPath("~/Files"), filename);
        //        file.SaveAs(filepath);
        //    }
        //    ViewBag.Message = "Uploaded file saved successfully in a folder !";
        //    return View();
        //}
        //catch
        //{
        //    ViewBag.Message = "Uploaded file not saved in a folder !";
        //    return View();
        //}
        //public ActionResult UploadFile()
        //{
        //    return View();
        //}
            
        //public ActionResult ViewFiles()
        //{
        //    return View();
        //}
        
    }
}