using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UI.Models;

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
        //反填用户的信息
        public IActionResult UserMessageUpt()
        {
            return View();
        }
    }
}