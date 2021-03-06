﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutenticacionSimpleMVC5.Controllers
{
    [Authorize] // a nivel de Controller
    public class HomeController : Controller
    {
        // GET: Home
        //[Authorize(Roles = "Admin")]
        [Authorize(Users = "Admin")]
        public ActionResult Index()
        {
            return View();
        }
    }
}