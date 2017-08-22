using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LibraryLatest(string page)
        {
            var client = new WebClient();
            client.Encoding = Encoding.UTF8;
            var resp = client.DownloadString("http://chinesepod.com/library/latest/?page=" + page);

            return Content(resp);
        }

        public ActionResult getSearchLesson(string search)
        {
            var client = new WebClient();
            client.Encoding = Encoding.UTF8;
            var resp = client.DownloadString(String.Format("http://chinesepod.com/library/search/fetch?search={0}&level=&page=0",search));

            return Content(resp);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}