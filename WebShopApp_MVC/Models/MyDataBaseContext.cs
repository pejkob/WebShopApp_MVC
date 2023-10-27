using Microsoft.EntityFrameworkCore;

namespace WebShopApp_MVC.Models
{
    public class MyDataBaseContext : DbContext
    {
        public MyDataBaseContext(DbContextOptions<MyDataBaseContext> options) : base(options)
        {
        }

        public MyDataBaseContext()
        {
        }

        public DbSet<Termek> Termek { get; set; }
        public DbSet<Kategoria> Kategoria { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost; database=webshop_mvc; user=root; password=");
            }
        }

    }
}
