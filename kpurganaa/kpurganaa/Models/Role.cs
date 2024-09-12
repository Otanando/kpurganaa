using System;
using System.Collections.Generic;

namespace kpurganaa.Models
{
    public partial class Role
    {
        public Role()
        {
            Admins = new HashSet<Admin>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdRol { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
