using System;
using System.Collections.Generic;

namespace WebShop_MVC_DbtoM.Models;

public partial class Kategorium
{
    public int Id { get; set; }

    public string? Nev { get; set; }

    public string? Leiras { get; set; }

    public virtual ICollection<Termek> Termeks { get; set; } = new List<Termek>();
}
