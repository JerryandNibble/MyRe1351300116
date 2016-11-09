using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Memo.Controllers
{
    public class CookiesController : Controller
    {
        // GET: Cookies
        public ActionResult Index()
        {
            int count = 1;

            var cookie = Request.Cookies["count"];
            if(cookie == null)
            {
                Response.Cookies.Add(new HttpCookie("count", "1"));
            }
            else
            {
                count = int.Parse(cookie.Value) + 1;
                var newcookie = new HttpCookie("count", count.ToString());
                Response.Cookies.Add(newcookie);
            }

            ViewBag.count = count;
            return View();
        }
    }
}