using System;
using System.Collections.Generic;

namespace WebShop_MVC_DbtoM.Models;

public partial class Termek
{
    public Termek(int id)
    {
        Id = id;
    }

    public int Id { get; set; }

    public string? Nev { get; set; }

    public string? Leiras { get; set; }

    public double Ar { get; set; }

    public bool Elerheto { get; set; }

    public string? FenykepUtvonal { get; set; }

    public int KategoriaId { get; set; }

    public virtual Kategorium Kategoria { get; set; } = null!;
}
