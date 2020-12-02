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
        [Route("/helloworld/")]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";
            return Content(html, "text/html");
        }

        /*[HttpGet]
        [Route("/helloworld/welcome/{name?}")]*/
        [HttpPost]
        [Route("/helloworld/")]
        public IActionResult Welcome(string name = "World!")
        {
            return Content("<h1>Welcome to my app, " + name + " </h1>", "text/html");
        }
    }
}
