﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab27MVCNetCore.Models;

namespace Lab27MVCNetCore.Controllers
{
    public class HomeController : Controller
    {
        public List<string> MyList;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult MyAction()
        {
            ViewBag.MyItem = "This is some data";
            ViewData["AnotherItem"] = "And some more data";
            MyList = new List<string>() { "one", "two", "3" };
            ViewBag.MyList = MyList;
            return View(MyList);
        }
    }
}
