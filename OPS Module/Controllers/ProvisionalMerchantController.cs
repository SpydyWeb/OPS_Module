using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelLayer.ProvisionalModel;
using DataLayer.Query;
using Microsoft.AspNetCore.Hosting;
using DataLayer.DBClass;

namespace OPS_Module.Controllers
{
    
    public class ProvisionalMerchantController : Controller
    {[Route("addprovisionalmerchant")]
        public IActionResult AddPovisionalMerchant()
        {
            var model = new ProvisionalMerchant();
            return View(model);
        }
        [HttpPost,Route("addprovisionalmerchant")]
        public virtual async Task<IActionResult> AddPovisionalMerchant(ProvisionalMerchant provisional)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
