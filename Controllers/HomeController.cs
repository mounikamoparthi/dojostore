using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using dojostore.Models;
using System.Linq;

namespace dojostore.Controllers
{
    public class HomeController : Controller
    {
        private dojoStoreContext _context;
 
        public HomeController(dojoStoreContext context)
        {
            _context = context;
        }
        // GET: /Home/
        [HttpGet]
        [Route("Customers")]
        public IActionResult Customers()
        {
            ViewBag.users = _context.users.ToList();
            return View();
        }
        [HttpPost]
        [Route("add")]
        public IActionResult add(User NewUser){
            
        }
    }
}
