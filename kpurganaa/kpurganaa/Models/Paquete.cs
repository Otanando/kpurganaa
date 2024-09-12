using System;
using System.Collections.Generic;

namespace kpurganaa.Models
{
    public partial class Paquete
    {
        public Paquete()
        {
            Reservas = new HashSet<Reserva>();
        }

        public int IdPaquete { get; set; }
        public int? IdServicio { get; set; }
        public int? IdHabitacion { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }

        public virtual Habitacione? IdHabitacionNavigation { get; set; }
        public virtual Servicio? IdServicioNavigation { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
