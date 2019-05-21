using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Whales.Models;

namespace Whales.Controllers
{
    public class HomeController : Controller
    {

        private WhaleContext context;
        
        public HomeController(WhaleContext w)
        {
            context = w;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Owners = context.Owners.ToList();
            // For version 2.1.2 of Entity Framework you have to use this...
            // ViewBag.Pets = context.Pets.Include(p => p.PetOwner).ToList();
            // For version 2.1.4 of Entity Framework you can use this...
            ViewBag.Pets = context.Pets.ToList();
            return View();
        }

        [Route("owner")]
        [HttpPost]
        public IActionResult CreateOwner(Owner o)
        {
            if(ModelState.IsValid)
            {
                context.Create(o);
            }
            return Redirect("/");
        }

        [Route("pet")]
        [HttpPost]
        public IActionResult CreatePet(Pet p)
        {
            if(ModelState.IsValid)
            {
                context.Create(p);
            }
            return Redirect("/");
        }

    }
}
