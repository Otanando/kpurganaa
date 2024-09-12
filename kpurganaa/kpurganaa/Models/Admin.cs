using System;
using System.Collections.Generic;

namespace kpurganaa.Models
{
    public partial class Admin
    {
        public int IdAdmin { get; set; }
        public int? IdRol { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Contraseña { get; set; } = null!;

        public virtual Role? IdRolNavigation { get; set; }
    }
}
