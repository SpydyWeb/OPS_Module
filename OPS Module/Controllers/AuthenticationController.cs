using Microsoft.AspNetCore.Mvc;
using ModelLayer.AuthenticationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OPS_Module.Controllers
{
    public class AuthenticationController : Controller
    {
        [Route("/")]
        [Route("login")]
        public virtual async Task<IActionResult> Login()
        {
            var model = new LogIn();
            return View(model);
        }
        [HttpPost,Route("login")]
        public virtual async Task<IActionResult> Login(LogIn log)
        {
            if (ModelState.IsValid)
            { 
            }
                return View(log);
        }
        [Route("signup")]
        public virtual async Task<IActionResult> SignUp()
        {
            var model = new SignUp();
            return View(model);
        }
        [HttpPost,Route("signup")]
        public virtual async Task<IActionResult> SignUp(SignUp signUp)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View(signUp);
        }
    }
}
