using System;
using System.Collections.Generic;

namespace DemoAppOne.Entites;

public partial class Usersrole
{
    public int IdRole { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
