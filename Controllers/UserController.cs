using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using dojostore.Models;
using System.Linq;

namespace dojostore.Controllers
{
    public class UserController : Controller
    {
        private dojoStoreContext _context;
 
        public UserController(dojoStoreContext context)
        {
            _context = context;
        }
        // GET: /User/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegisterViewModel model)
        {
            if(ModelState.IsValid){
                User NewUser = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EmailId = model.EmailId,
                    Password = model.Password,
                   
                };
                _context.Add(NewUser);
                _context.SaveChanges();
                System.Console.WriteLine("Done adding to DB");
                User EnteredPerson = _context.users.SingleOrDefault(user => user.EmailId == model.EmailId);
                HttpContext.Session.SetString("FirstName", EnteredPerson.FirstName);
                HttpContext.Session.SetInt32("UserId",EnteredPerson.UserId);
                return RedirectToAction("customers");
            }
            else 
            {
                ViewBag.errors = ModelState.Values;
                 ViewBag.Errors = new List<string>();
                return View("Index");
            }
        }
        [HttpPost]
        [Route("PostLogin")]
        public IActionResult PostLogin(string EmailId, string Password)
        {
             User loggedUser = _context.users.SingleOrDefault(user => user.EmailId == EmailId);
             if (loggedUser != null)
             {
                HttpContext.Session.SetString("FirstName", loggedUser.FirstName);
                HttpContext.Session.SetInt32("UserId", loggedUser.UserId);
                return RedirectToAction("customers");
             }

               ViewBag.Errors = new List<string>(){ "Check Username and password"};
                return View("Index");
        }
        [HttpGet]
        [Route("customers")]
        public IActionResult customers(){
            return View("customers");
        }
        [HttpPost]
        [Route("add")]
        public IActionResult add(){
            return RedirectToAction("customers");
        }
        
        [HttpGet]
        [Route("logout")]
        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
       
    }
}
