using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FanPage.Controllers
{
    public class SourcesController : Controller
    {
        [HttpGet]
        public ViewResult Sources()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Media()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Online()
        {
            return View();
        }
    }
}