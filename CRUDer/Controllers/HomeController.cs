using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDer.Controllers
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

        [HttpPost]
        public JsonResult GetDetail() {
            return Json(
                new List<object>() {
                    new Post() { Title = "zhao", PostTime = "zhao", LastUpdatedTime = "zhao", Author = "zhao"},
                    new Post() { Title = "zhao", PostTime = "zhao", LastUpdatedTime = "zhao", Author = "zhao"},
                    new Post() { Title = "zhao", PostTime = "zhao", LastUpdatedTime = "zhao", Author = "zhao"}
                }
                ,JsonRequestBehavior.AllowGet);
        }
    }

    public class Post {
        public string Title { get; set; }
        public string PostTime { get; set; }
        public string LastUpdatedTime { get; set; }
        public string Author { get; set; }
    }
}