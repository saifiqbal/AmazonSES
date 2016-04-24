using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmazonSES.Areas.Mozart.Controllers
{
    public class UserController : Controller
    {
        // GET: Mozart/User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}