﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab32MVCCoreEntityNorthwind.Controllers
{
    public class SpecialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DoubleSpecial()
        {
            return View("SingleSpecial");
        }
    }
}