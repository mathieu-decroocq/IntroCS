using Cesi.IntroCS.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cesi.IntroCS.MVC.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public ActionResult Send()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Send(ContactModel contact)
        {
            if (ModelState.IsValid)
                return RedirectToAction("Index", "Home");

            //todo save contact request
            return View();
        }
    }
}