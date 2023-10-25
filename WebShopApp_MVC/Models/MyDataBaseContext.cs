using Microsoft.EntityFrameworkCore;

namespace WebShopApp_MVC.Models
{
    public class MyDataBaseContext : DbContext
    {
        public MyDataBaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Termek> Termek { get; set; }
        public DbSet<Kategoria> Kategoria { get; set; }
        

    }
}
