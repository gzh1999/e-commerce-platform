using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

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
        /// <summary>
        /// 设置客户端信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Soto()
        {
            
            SetCookies("11", "xxx", 60);
            string tool = GetCookiesValue("CookiesKey");
           
            return View();
        }
        #region 控制器，服务器
        private readonly IHttpContextAccessor __httpContextAccessor;
        private ISession _session => __httpContextAccessor.HttpContext.Session;

        protected void SetCookies(string key, string value, int Minutes = 30)
        {
            HttpContext.Response.Cookies.Append(key, value, new CookieOptions { Expires = DateTime.Now.AddMinutes(Minutes) });


        }

        protected void DeleteCookies(string key)
        {
            HttpContext.Response.Cookies.Delete(key);

        }
        /// <summary>
        /// 获取客户端信息
        /// </summary>
        /// <returns></returns>
        public IActionResult baseTool()
        {
            var ki=GetCookiesValue("CookiesKey");
            ViewBag.ki = ki;
            List<FourThis> list = new List<FourThis>();
           
            return View();
        }
        protected string GetCookiesValue(string key)
        {
            HttpContext.Request.Cookies.TryGetValue(key, out string value);
            if (string.IsNullOrEmpty(value))
            {
                value = string.Empty;

            }
            return value;

        }

        public void SetSession(string sesionStr, string Code)
        {
            _session.SetString(sesionStr, Code);
        }
        public string GetSessoin(string sesionStr)
        {
            string code = _session.GetString(sesionStr);
            return code;
        }

        #endregion
        [HttpGet("so")]
        public ActionResult ssOw()
        {
            int free = 12;
            ViewBag.free = free;
            return View();

        }

        delegate ActionResult TO();
        
    
        public  ActionResult NeedWere()
        {
            TO t = NeedWere;
            string tool = "Css";
            ViewBag.tool = tool;
            return View(tool);
        }

        public ActionResult WoW()
        {
            TO t = NeedWere;
            ViewBag.t = t;
            return View();
        }


    }
}