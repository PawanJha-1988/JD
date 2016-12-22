using JD.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JD.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult addUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addUser(Users oUsers)
        {
            return View();
        }
    }
}