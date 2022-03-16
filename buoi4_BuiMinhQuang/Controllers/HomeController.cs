using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using buoi4_BuiMinhQuang.Models;
using PagedList;

namespace buoi4_BuiMinhQuang.Controllers
{
    public class HomeController : Controller
    {
        MyDatamlDataContext data = new MyDatamlDataContext();
        public ActionResult Index(int? page)
        {
            if (page == null)
                page = 1;
            var list = data.Saches.OrderBy(m => m.masach);
            int pageSize = 3;
            int pageNumb = page ?? 1;
            return View(list.ToPagedList(pageNumb, pageSize));
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
    }
}