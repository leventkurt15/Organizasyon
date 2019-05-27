using Organizasyon.BLL;
using Organizasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Organizasyon.Controllers
{
    public class LoginController : Controller
    {
        
        // GET: Login
        public ActionResult Index()
        {
            

            return View();
        }


        public ActionResult KayıtEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KayıtEkle(Login log)
        {
           
            LoginBLL.KayıtEkle(log);



            return RedirectToAction("Uyeol"); 

        }


        public ActionResult Uyeol()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Uyeol(Login logi)
        {
            var uyeol = LoginBLL.Uyeol(logi.Username, logi.Password);
            if (uyeol == null)
            {
                return RedirectToAction("Hata", "Home");
            }
            else
            {
                Session["Login"] = uyeol;
            }


            return View();
        }
        
    }
}