﻿using _69zg.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static _69zg.Common.ResquestUtil;

namespace _69zg.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(string url)
        {
            ViewBag.url = url;//url;
            return View();
        }

        [HttpPost]
        public JsonResult Login()
        {
            string pwd = RequestUtil.GetValue(Request, "upd");
            string name = RequestUtil.GetValue(Request, "uname");
            string url= RequestUtil.GetValue(Request, "sourceurl");
            string flag = "SUCCESS";
            if (string.IsNullOrEmpty(pwd) || string.IsNullOrEmpty(name))
            {
                flag = "FAILED";
            }
            string []jsonresul = { flag, url };
            return Json(jsonresul,JsonRequestBehavior.DenyGet);
        }
    }
}