using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagementDemo.Controllers
{
    public class TempController : Controller
    {
        public IActionResult First()
        {
            TempData["UserId"] = 100;
            return View();
        }
        public IActionResult Second()
        {
            var userid = TempData["UserId"] ?? null;
            return View();
        }
        public IActionResult Third()
        {
            var userid = TempData["UserId"] ?? null;
            return View();
        }
    }
}
