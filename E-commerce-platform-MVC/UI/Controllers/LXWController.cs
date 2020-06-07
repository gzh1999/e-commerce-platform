using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class LXWController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Del()
        {
            return View();
        }

        public IActionResult Upt()
        {

            return View();
        }
        public IActionResult Fill(int id)
        {
            return View();
        }
    }
}