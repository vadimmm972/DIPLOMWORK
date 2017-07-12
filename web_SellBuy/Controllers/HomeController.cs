using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_SellBuy.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            //ViewBag.Authentication = null;
            //if (Request.Cookies["AuthenticationSellBuy"] != null)
            //{
            //    var value = Request.Cookies["AuthenticationSellBuy"].Value;
            //    ViewBag.Authentication = value;
            //}
            return View();
        }
	}
}