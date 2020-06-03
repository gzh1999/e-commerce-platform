using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class TabycxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 男装的人数
        /// </summary>
        /// <returns></returns>
        public IActionResult ManTries()
        {
            return View();
        }
        /// <summary>
        /// 女装
        /// </summary>
        /// <returns></returns>
        public IActionResult WomenTries()
        {
            return View();
        }
        /// <summary>
        /// 童装
        /// </summary>
        /// <returns></returns>
        public IActionResult BoyTries()
        {
            return View();
        }
        
        public IActionResult AllTapStatistics()
        {
            return View();
        }
        public IActionResult So()
        {
            return View();
        }
    }
}