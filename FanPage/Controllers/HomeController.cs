using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanPage.Models;

namespace FanPage.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("index");
        }
        [HttpGet]
        public ViewResult History()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Stories()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Sources()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Online()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Media()
        {
            return View();
        }
    }
}
