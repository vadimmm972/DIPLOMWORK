using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_SellBuy.Controllers
{
    public class AuthenticationController : Controller
    {
     
        //
        // GET: /Authentication/
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult SignIn()
        {
          
            return View(); 
        }

        public ActionResult Authorization()
        {
          
            return View();
        }


        public int AuthorizationUser()
        {
            return 1;
        }
	}
}