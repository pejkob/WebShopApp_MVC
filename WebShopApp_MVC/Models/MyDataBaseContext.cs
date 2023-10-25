using Microsoft.EntityFrameworkCore;

namespace WebShopApp_MVC.Models
{
    public class MyDataBaseContext : DbContext
    {
    

        public DbSet<Termek> Termek { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("SERVER=localhost;PORT=3306;DATABASE=webshop_mvc;USER=root;PASSWORD=;SSL MODE=none;");
            }
        }

    }
}
