using DB_Entity_DAL.DB_Operations;
using DB_Entity_DAL.MedelsDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_SellBuy.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Base/
        public ActionResult Index()
        {
            //Brand b = new Brand
            //{
            //    name_brand = "asdass"
            //};

            //DB_Brand n = new DB_Brand();
            //n.InsertBrand(b);
            return View("index");
        }

        //[HttpGet]
        //public ActionResult SI()
        //{
        //    return View("SI");
        //}
	}
}