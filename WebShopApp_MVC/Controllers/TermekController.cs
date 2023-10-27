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

        [HttpPut]

        public IActionResult Put(Termek termek)
        {
            using (var context = new MyDataBaseContext())
            {
                try
                {

                    context.Update<Termek>(termek);
                    context.SaveChanges();
                    return StatusCode(statusCode: 204, "A termék adatai sikeresen módosítva");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            using (var context=new MyDataBaseContext())
            {
                try
                {
                    Termek termek = new(id);
                   
                    context.Remove<Termek>(termek);
                    //context.Remove<Termek>(context.Termek.First(termek=>termek.Id==id));
                    context.SaveChanges();
                    return StatusCode(statusCode: 200, $"A termék sikeresen törölve! (ID:{id})");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

    }
}