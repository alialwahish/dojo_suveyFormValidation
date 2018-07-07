using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcDojSurv.Models;

namespace MvcDojSurv.Controllers
{
    public class HomeController : Controller
    {
        Ninja ninja = new Ninja();
       
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(ninja);
        }
        
        [HttpPost("Home/create")]
        public IActionResult Details(Ninja ninja){
                Console.WriteLine("Trying to check validation");
            if(ModelState.IsValid){
                Console.WriteLine("Valid");
                return View(ninja);
            }       
            else{
                Console.WriteLine("Not Valid");
                return View("Index");
            }
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
