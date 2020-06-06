using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult OrdersShow()
        {
            return View();
        }
        public IActionResult StatesShow()
        {
            return View();
        }
        public IActionResult Find()
        {
            return View();
        }
        public IActionResult FindId()
        {
            return View();
        }
        public IActionResult Upt()
        {
            return View();
        }
    }
}