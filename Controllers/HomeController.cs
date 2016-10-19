﻿using HRMVer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMVer4.Controllers
{
    public class HomeController : Controller
    {
        private HRMVer4Context db = new HRMVer4Context();
        public ActionResult Index()
        {
            return View(db.Posts.ToList());
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