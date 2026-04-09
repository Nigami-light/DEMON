using System;
using System.Collections.Generic;

namespace DemoAppOne.Entites;

public partial class Pvz
{
    public int IdPvz { get; set; }

    public string Adress { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
