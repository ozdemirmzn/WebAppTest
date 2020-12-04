using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTest.Controllers
{
    
    public class HelloController : Controller
    {
        [HttpGet]
        
        public IActionResult Index()
        {
            return View();
        }

        /*[HttpGet]
        [Route("/helloworld/welcome/{name?}")]*/
        //[HttpGet("welcome/{name?}")]
        [HttpPost]
        [Route("/hello/")]
        public IActionResult Welcome(string name = "World!")
        {
            ViewBag.person = name;
            return View();
            
            // return Content("<h1>Welcome to my app, " + name + " </h1>", "text/html");
        }
    }
}
