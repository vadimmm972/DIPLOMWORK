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
            return PartialView("UserProfile");
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


        [HttpPost]
        public string UpdateInfoMyProfileInParam(int _idparam,string newInfo)
        {
            string resultString = "";
            if (Request.Cookies["AuthenticationSellBuy"] != null)
            {
                int id = Convert.ToInt16(Request.Cookies["AuthenticationSellBuy"].Value);
                resultString = upUsInfo.UpdateInfoProfileByParamsTools(_idparam, id, newInfo);
            }
            return resultString;
        }

         [HttpPost]
        public string UpdateLocationUserProfile(int _idCountry , int _idRegion , int _idCity)
        {

            string resultString = "";
            if (Request.Cookies["AuthenticationSellBuy"] != null)
            {
                int id = Convert.ToInt16(Request.Cookies["AuthenticationSellBuy"].Value);
                resultString = upUsInfo.UpdateLocationProfileTools(id, _idCountry, _idRegion, _idCity);
            }
            return resultString;
        }
	}
}