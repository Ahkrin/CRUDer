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
                new List<object>{new Dictionary<object,object> {
                    {"Title","タイトル" },
                    {"PostTime","投稿時点" },
                    {"LastUpdatedTime","最後の改修日" },
                    {"Author","投稿人" }
                },
                new List<object>() {
                            new Post() { Title = "zhao", PostTime = DateTime.Now, LastUpdatedTime = DateTime.Now, Author = "zhao"},
                            new Post() { Title = "zhao", PostTime = DateTime.Now, LastUpdatedTime = DateTime.Now, Author = "zhao"},
                            new Post() { Title = "zhao", PostTime = DateTime.Now, LastUpdatedTime = DateTime.Now, Author = "zhao"}
                        }}                
                ,JsonRequestBehavior.AllowGet);
        }
    }

    public class Post {        
        public string Title { get; set; }
        public DateTime PostTime { get; set; }
        public DateTime LastUpdatedTime { get; set; }
        public string Author { get; set; }
    }
}