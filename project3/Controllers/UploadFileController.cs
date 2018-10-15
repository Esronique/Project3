using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace project3.Controllers
{
    public class UploadFileController : Controller
    {
        // GET: UploadFile
        public ActionResult UploadFile()
        {
            var path = Server.MapPath("~/Files/");
            var dir = new DirectoryInfo(path);
            var files = dir.EnumerateFiles().Select(c => c.Name);

            return View(files);
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
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

            var path = Path.Combine(Server.MapPath("~/Files/"), file.FileName);
            var data = new byte[file.ContentLength];
            file.InputStream.Read(data, 0, file.ContentLength);

            using (var sw = new FileStream(path, FileMode.Create))
            {
                sw.Write(data, 0, data.Length);
            }

            return RedirectToAction("UploadFile");
        }
    }
}