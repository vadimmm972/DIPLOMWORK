using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OperationTools;

namespace web_SellBuy.Controllers
{
    public class AuthenticationController : Controller
    {
        private AuthenticationTools userTools = new AuthenticationTools();
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


        public int AuthorizationUser(string _surname, string _name, string _lastname
            , string _phone, string _email, string _login
            , string _password, int _idcountry, int _idRegion
            , int _idSity, string _photo)
        {
            int resAddUser = userTools.RegisterUser(_surname, _name, _lastname, _phone, _email, _login, _password, _idcountry, _idRegion, _idSity, _photo);
            return resAddUser;
        }



	}
}