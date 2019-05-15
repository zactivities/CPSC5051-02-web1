﻿using System;
using web1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var myData = new HomeViewModel
            {
                PhoneCount = 10,
                UserCount = 15,
                LastAccessDate = DateTime.Now
            };
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}