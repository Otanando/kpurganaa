using System;
using System.Collections.Generic;

namespace kpurganaa.Models
{
    public partial class Habitacione
    {
        public Habitacione()
        {
            Paquetes = new HashSet<Paquete>();
            Reservas = new HashSet<Reserva>();
        }

        public int IdHabitacion { get; set; }
        public string Numerohabitacion { get; set; } = null!;
        public decimal Precio { get; set; }
        public int Capacidad { get; set; }
        public string Estado { get; set; } = null!;
        public string? Descripcion { get; set; }

        public virtual ICollection<Paquete> Paquetes { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
