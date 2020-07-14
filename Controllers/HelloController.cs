using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" +
                "<input type='text' name='name'/>" +
                "<select name='language'>" +
                "<option value='English'>English</option>" +
                "<option value='French'>French</option>" +
                "<option value='Spanish'>Spanish</option>" +
                "<option value='German'>German</option>" +
                "<option value='Portuguese'>Portuguese</option>" +
                "</select>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";
            return Content(html, "text/html");
        }

        //[HttpGet]
        //[Route("/helloworld/welcome/{name?}")]

        /*
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
        */

        [HttpGet("createmessage/{name?}")]
        [HttpPost]
        public IActionResult CreateMessage(string name = "World", string language = "English")
        {
            if (language == "English")
            {
                return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
            }

            if (language == "French")
            {
                return Content("<h1>Bienvenue sur mon application, " + name + "!</h1>", "text/html");
            }

            if (language == "Spanish") {
                return Content("<h1>Bienvenido a mi aplicación, " + name + "!</h1>", "text/html");
            }

            if (language == "German")
            {
                return Content("<h1>Willkommen in meiner App, " + name + "!</h1>", "text/html");
            }

            if (language == "Portuguese")
            {
                return Content("<h1>Bem-vindo ao meu aplicativo, " + name + "!</h1>", "text/html");
            }

            return null;
        }
    }
}
