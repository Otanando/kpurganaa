using System;
using System.Collections.Generic;

namespace kpurganaa.Models
{
    public partial class Reserva
    {
        public int IdReserva { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdHabitacion { get; set; }
        public int? IdServicio { get; set; }
        public int? IdPaquete { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Total { get; set; }

        public virtual Habitacione? IdHabitacionNavigation { get; set; }
        public virtual Paquete? IdPaqueteNavigation { get; set; }
        public virtual Servicio? IdServicioNavigation { get; set; }
        public virtual Usuario? IdUsuarioNavigation { get; set; }
    }
}
