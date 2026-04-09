using System;
using System.Collections.Generic;

namespace DemoAppOne.Entites;

public partial class Usersorder
{
    public int IdUserOrder { get; set; }

    public int? UserId { get; set; }

    public int? OrderId { get; set; }

    public virtual Order? Order { get; set; }

    public virtual User? User { get; set; }
}
