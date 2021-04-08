using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcllentBacisApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Attendance()
        {
            return View();
        }

        public IActionResult Diary1()
        {
            return View();
        }
        public IActionResult Diary2()
        {
            return View();
        }
    }
}
