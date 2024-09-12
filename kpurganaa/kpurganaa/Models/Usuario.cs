using System;
using System.Collections.Generic;

namespace kpurganaa.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            ReservasNavigation = new HashSet<Reserva>();
        }

        public int IdUsuario { get; set; }
        public int? IdRol { get; set; }
        public int? Reservas { get; set; }
        public string? EstadoReserva { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string NroDocumento { get; set; } = null!;
        public string? Celular { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        public virtual Role? IdRolNavigation { get; set; }
        public virtual ICollection<Reserva> ReservasNavigation { get; set; }
    }
}
