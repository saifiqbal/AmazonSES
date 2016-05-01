using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Amazon.SimpleEmail;

namespace AmazonSES.Views
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            AmazonSES.Helpers.AmazonSimpleEmailHelper sesHelper = new Helpers.AmazonSimpleEmailHelper();
            sesHelper.SendEmail("From", "To", "Subject", "Body");
            return View();
        }
    }
}