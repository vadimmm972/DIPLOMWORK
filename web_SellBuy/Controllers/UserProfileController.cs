﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_SellBuy.Controllers
{
    public class UserProfileController : Controller
    {
        //
        // GET: /UserProfile/
        public ActionResult Index()
        {
            return View("UserProfile");
        }
	}
}