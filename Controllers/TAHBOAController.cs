using _69zg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/// <summary>
/// niezl add 2017年3月2日
/// </summary>

namespace _69zg.Controllers
{
    public class TAHBOAController : Controller
    {
        // GET: TAHBOA
        public ActionResult Index()
        {
            Users users = Session["currentuser"] as Users;
            if (users != null)
            {
                ViewBag.username = users.Uname;
            }
            else
            {
                ViewBag.username = "游客";
            }
            return View();
        }
    }
}