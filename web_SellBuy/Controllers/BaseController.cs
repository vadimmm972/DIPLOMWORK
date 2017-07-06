using DB_Entity_DAL.DB_Operations;
using DB_Entity_DAL.MedelsDataBase;
using System;
using System.Collections.Generic;
using System.IO;
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
           
            return View("index");
        }


        public JsonResult UploadImage()
        {
            Random rand = new Random();

            int temp;

            temp = rand.Next(1000000000);
            var pic = System.Web.HttpContext.Current.Request.Files["HelpSectionImages"];
            var id = System.Web.HttpContext.Current.Request.Form["id"];
            var operation = System.Web.HttpContext.Current.Request.Form["operation"];

            var fileName = "profile_";
            fileName += temp;
            fileName += "_";

            fileName += "us.jpg";

            if (operation == "1")
            {
                var path = Path.Combine(Server.MapPath("~/Content/images/imagesPhotos"), fileName.Trim());
                pic.SaveAs(path);
            }
            if (operation == "2")
            {
                var path = Path.Combine(Server.MapPath("~/Content/images/userPhotoForProfile"), fileName.Trim());
                pic.SaveAs(path);
                ViewBag.PhotoUser = fileName.Trim();
            }

            var imgpath = "~/Content/images/userPhotoForProfile" + fileName.Trim();

            // var jsonResult = Json(imgpath, JsonRequestBehavior.AllowGet);
            return Json(fileName.Trim());

        }
	}



}