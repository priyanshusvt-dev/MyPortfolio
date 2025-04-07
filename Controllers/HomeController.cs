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
            return "id parameter ="+id;
        }
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
    }
}