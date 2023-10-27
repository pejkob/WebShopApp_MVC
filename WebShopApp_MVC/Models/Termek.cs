namespace WebShopApp_MVC.Models
{
    public class Termek:Record
    {
        public Termek(int id)
        {
            Id = id;
        }

        public string? Nev {get; set;}
        public int KategoriaId { get; set;}
        public string? Leiras {get; set;}
        public double Ar {get; set;}
        public bool Elerheto { get; set;}

        public string? FenykepUtvonal { get; set;}
        
    }
}
