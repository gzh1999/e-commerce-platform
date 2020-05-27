using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class StatisticssController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Homepage()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        //忘记密码
        public IActionResult ForgetPass(int id=0)
        {
            ViewBag.UserId = id;
            return View();
        }
        //反填用户信息
        public IActionResult UserInfoFill()
        {
            return View();
        }
        public IActionResult UserInfoPassUpt()
        {
            return View();
        }
    }
}