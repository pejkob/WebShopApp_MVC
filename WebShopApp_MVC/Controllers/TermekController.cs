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
        
        public static List<Termek> TermekGet(MyDataBaseContext context)
        {
            return context.Termek.OrderBy(f=>f.Nev).ToList();   
        }

        [HttpGet]
        public IActionResult Get()
        {
            using (var context = new MyDataBaseContext())
            {
                try
                {
                    return Ok(TermekGet(context));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpGet("{nev}")]

        public IActionResult GetByName(string nev)
        {
            using (var context = new MyDataBaseContext())
            {
                try
                {
                    return StatusCode(statusCode: 200, context.Termek.FirstOrDefault(termekNev => termekNev.Nev == nev));
                
                }
                catch (Exception ex)
                {

                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpPost]

        public IActionResult Post(Termek ujTermek)
        {
            using(var context = new MyDataBaseContext())
            {
                try
                {
                    
                    context.Add<Termek>(ujTermek);
                    context.SaveChanges();
                    return StatusCode(statusCode:202,"Az új adat sikeresen felvéve");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }    
        }
       
       
    }
}