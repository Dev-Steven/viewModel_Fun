using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewModelFun.Models;

namespace viewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet ("")]
        public IActionResult Index()
        {
            string message = "Hello hello helooooo!?";
            return View("Index", message);
        }

        [HttpGet ("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1, 6, 8, 24
            };
            return View("Numbers", numbers);
        }

        [HttpGet ("users")]
        public IActionResult Users()
        {
            User steven = new User("Steven", "Chung");
            User bob = new User("Bob", "G.");
            User tom = new User("Tom", "C.");

            List<User> users = new List<User>()
            {
                steven, bob, tom
            };

            return View("Users", users);
        }

        [HttpGet ("user")]
        public IActionResult User()
        {
            User steven = new User("Steven", "Chung");
            return View("User", steven);
        }
    }
}
