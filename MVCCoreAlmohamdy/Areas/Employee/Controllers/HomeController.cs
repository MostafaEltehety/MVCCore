﻿using Microsoft.AspNetCore.Mvc;

namespace MVCCoreAlmohamdy.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
