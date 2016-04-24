using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmazonSES.Areas.Mozart.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        // GET: Mozart/Profile
        public ActionResult Index()
        {
            return View();
        }
    }
}