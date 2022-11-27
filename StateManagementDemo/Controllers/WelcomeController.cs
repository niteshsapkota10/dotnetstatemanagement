using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StateManagementDemo.Models;

namespace StateManagementDemo.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name", "Yujan");
            HttpContext.Session.SetInt32("Age", 20);
            return View();
        }
        public IActionResult Get()
        {
            User newuser = new User()
            {
                Name = HttpContext.Session.GetString("Name"),
                Age = HttpContext.Session.GetInt32("Age").Value
            };
            return View(newuser);
        }
        public IActionResult GetQueryString(string name, int age)
        {
            User newuser = new User()
            {
                Name=name,
                Age=age
            };
            return View(newuser);
        }
        public IActionResult SetHiddenFieldValue()
        {
            User newuser = new User() { Id = 404, Name = "Jemmy Maharjan", Age = 21 };
            return View(newuser);
        }
        [HttpPost]
        public IActionResult SetHiddenFieldValue(IFormCollection form)
        {
            var id = form["Id"];
            return View();
        }
    }
}
