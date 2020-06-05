using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class syController : Controller
    {
        /// <summary>
        /// 商品
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowGoods()
        {
            return View();
        }
        public ActionResult Show2()
        {
            return View();
        }
        public ActionResult AddGoods()
        {
            return View();
        }
        public ActionResult FillGoods()
        {
            return View();
        }
        public ActionResult UptGoods()
        {
            return View();
        }
        public ActionResult UptGoodsStatus()
        {
            return View();
        }
        public ActionResult DelGoods()
        {
            return View();
        }

        /// <summary>
        /// 类型
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowType()
        {
            return View();
        }
        public ActionResult AddType()
        {
            return View();
        }
        public ActionResult DelType()
        {
            return View();
        }
    }
}