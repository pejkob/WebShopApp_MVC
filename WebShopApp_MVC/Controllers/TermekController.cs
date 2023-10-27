using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using WebShopApp_MVC.Models;
using System.Linq;

namespace WebShopApp_MVC.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TermekController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            using (var context = new MyDataBaseContext())
            {
                try
                {
                    var termekList = context.Termek.ToList();
                    return Ok(termekList);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
       
       
    }
}