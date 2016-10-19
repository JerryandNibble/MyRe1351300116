using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Memo.Controllers
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult News()
        {
            String[] data = new string[] { "神十一与天宫对接成功 航天员“入宫”", "李克强：奋力开创东北全面振兴新局面", "孩子们还适不适合阅读“四大名著”" };
            ViewBag.data = data;
            return View();
        }

        public ActionResult Welcome()
        {
            
            return View();
        }
    }
}