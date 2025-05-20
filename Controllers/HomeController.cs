using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PriyanshuPortfolio.Controllers
{
    public class HomeController : Controller
    {
        //Nullable type parameter
        public string Index(int? id)
        {
            if (id.HasValue)
            {

            }
            return "id parameter =" + id;
        }
        //query string type parameter
        public string Login(string userid,int password)
        {
            if (userid == "techpile" && password == 123)
            {
                return "Successful";
            }
            else
            {
                return "Unsucessful";
            }
        }
        public ViewResult FirstPage()
        {
            return View();
        }
        public ViewResult Services()
        {
            return View();
        }
        public ViewResult About()
        {
            return View();
        }
        public ViewResult Contactme()
        {
            return View();
        }
        public ViewResult Auth()
        {
            return View();
        }
    }
}