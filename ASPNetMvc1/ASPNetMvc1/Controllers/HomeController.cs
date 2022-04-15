using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetMvc1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            if (id == null)
            {
                return Content("<h1>This is demo of ContentResult</h1>");
            }
            else if (id.ToLower() == "plain")
            {
                return Content("<h1> This is demo of ContentResult</h1>", "text/plain");
            }
            else if (id.ToLower() == "html")
            {
                return Content("<h1> This is demo of ContentResult</h1>", "text/html");
            }
            else if (id.ToLower() == "xml")
            {
                return Content("<h1> This is demo of ContentResult</h1>", "text/xml");
            }
            return Content("Invalid content type");
        }
        public ActionResult DownloadFile() 
        { 
            if (!System.IO.File.Exists(@"e:\Wall-of-China-17.jpg"))
            { 
                return Content("File to be downloaded not found");
            }
                return File(@"e:\Wall-of-China-17.jpg", "image/jpg", "default.jpg"); 
        }

        public ActionResult Google()
        {
            return Redirect("http://wwww.google.com");
        }
        public ActionResult StartPage() 
        { 
            return RedirectToAction("Index", new { id = "xml" }); 
        }
        public ActionResult Login() 
        {
            return View(); 
        }
        public ActionResult AboutUs() 
        { 
            return View(); 
        }
    }
}
     