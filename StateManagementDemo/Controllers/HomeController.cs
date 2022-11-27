using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using StateManagementDemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagementDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string username = Request.Cookies["username"];
            return View("Index",username);
        }
        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            string username = form["username"].ToString();
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddMinutes(20);
            Response.Cookies.Append("username", username, options);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult DeleteCookie()
        {
            Response.Cookies.Delete("username");
            return View("Index");
        }
    }
}
