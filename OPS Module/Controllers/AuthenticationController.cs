using Microsoft.AspNetCore.Mvc;
using ModelLayer.AuthenticationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Query;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace OPS_Module.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationQuery _query;
        private readonly IWebHostEnvironment _hostEnvironment;

        public AuthenticationController(IAuthenticationQuery query, IWebHostEnvironment hostEnvironment)
        {
            _query = query;
            _hostEnvironment = hostEnvironment;
        }
        [Route("/")]
        [Route("login")]
        public virtual IActionResult Login()
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
        public virtual IActionResult SignUp()
        {
            var model = new SignUp();
            return View(model);
        }
        [HttpPost,Route("signup")]
        public virtual async Task<IActionResult> SignUp(SignUp signUp)
        {
            if (ModelState.IsValid)
            {
                if (await _query.register(signUp))
                {
                    if(signUp.PancardImage!=null)
                    {
                        string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "Images");
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" +signUp.EmployeeName+ signUp.PancardImage.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            signUp.PancardImage.CopyTo(fileStream);
                        }
                        signUp.pancardimagepath = filePath;
                    }
                    if(signUp.AdharcardImage!=null)
                    {
                        string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "Images");
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + signUp.EmployeeName + signUp.AdharcardImage.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            signUp.PancardImage.CopyTo(fileStream);
                        }
                        signUp.aadharcardimagepath = filePath;
                    }
                    if(signUp.EmployeeImage!=null)
                    {
                        string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "Images");
                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + signUp.EmployeeName + signUp.EmployeeImage.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            signUp.PancardImage.CopyTo(fileStream);
                        }
                        signUp.employeeimagepath = filePath;
                    }
                    var added = await _query.addemployeedetailsAsync(signUp);
                    if(added>0)
                    {
                        return RedirectToAction(nameof(Login));
                    }
                }
            }
            return View(signUp);
        }
    }
}
