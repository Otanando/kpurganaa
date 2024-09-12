using System;
using System.Collections.Generic;

namespace kpurganaa.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            Paquetes = new HashSet<Paquete>();
            Reservas = new HashSet<Reserva>();
        }

        public int IdServicio { get; set; }
        public string Nombre { get; set; } = null!;
        public int? Capacidad { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }

        public virtual ICollection<Paquete> Paquetes { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
