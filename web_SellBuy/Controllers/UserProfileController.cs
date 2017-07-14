using OperationTools.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_SellBuy.Controllers
{
    public class UserProfileController : Controller
    {
        UpdateInfoUserProfileTools upUsInfo = new UpdateInfoUserProfileTools();
        //
        // GET: /UserProfile/
        public ActionResult Index()
        {
            return View("UserProfile");
        }


        public JsonResult LoadUserInfo()
        {
            if (Request.Cookies["AuthenticationSellBuy"] != null)
            {
                var value = Request.Cookies["AuthenticationSellBuy"].Value;
                return Json(   upUsInfo.GetAllInfoUser(Convert.ToInt16(value)));
            }
            return Json(null);
        }
	}
}