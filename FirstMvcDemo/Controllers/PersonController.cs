using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FirstMvcDemo.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult PersonalDetails()
        {
            List<string> options = new List<string>() { "Select option", "Yes", "No" };
            ViewData["options"]=new SelectList(options);
            return View();
        }

        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form,ICollection<string> hobbies)
        {
            ViewBag.Name = form["fname"];
            ViewBag.Contact = form["contact"];
            ViewBag.Gender = form["gender"];
            ViewBag.Hobbies=hobbies;
            ViewBag.Option = form["options"];
            return View("Details");
        }
    }
}
