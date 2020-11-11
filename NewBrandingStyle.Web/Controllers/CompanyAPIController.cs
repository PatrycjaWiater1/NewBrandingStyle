using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;

namespace NewBrandingStyle.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyAPIController : ControllerBase
    { 
        [HttpPost]
        [Route("AddNewItem")]
        public IActionResult AddNewItem(CompanyModel companyModel)
        {
            return Ok("Item added succesfully!");
        }
    }
}