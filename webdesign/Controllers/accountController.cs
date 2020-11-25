using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webdesign.Models;

namespace webdesign.Controllers
{
    public class accountController : Controller
    {
        public IActionResult login()
        {
            return View();
        }
        /*
        [HttpPost]
        public ContentResult  login(string username ,string password)
        {
            if(username=="buseykbs" && password=="1234")
            {
                return Content("welcome buse");
            }
            else
            {
                return Content("sorry" + username);
            }
        }*/
        // complex model binding
        [HttpPost]
        public ContentResult login(user model)
        {
            if (model.username == "buseykbs" && model.password == "1234")
            {
                return Content("welcome buse");
            }
            else
            {
                return Content("sorry" + model.username);
            }
        }

        public IActionResult form()
        {
            return View();
        }
        public IActionResult giriş()
        {
            return View();
        }
    }
}
