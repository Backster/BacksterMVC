﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyOwnMVC.Controllers
{
    public class InformationController : Controller
    {
        // GET: Information

        public ActionResult ViewInfo()
        {
            return View();
        }
    }
}