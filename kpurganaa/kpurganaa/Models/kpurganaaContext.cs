using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace kpurganaa.Models
{
    public partial class kpurganaaContext : DbContext
    {
        public kpurganaaContext()
        {
        }

        public kpurganaaContext(DbContextOptions<kpurganaaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Habitacione> Habitaciones { get; set; } = null!;
        public virtual DbSet<Paquete> Paquetes { get; set; } = null!;
        public virtual DbSet<Reserva> Reservas { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Servicio> Servicios { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\Fernando; database=kpurganaa; Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.IdAdmin)
                    .HasName("PK__Admin__89472E9577A7A267");

                entity.ToTable("Admin");

                entity.HasIndex(e => e.Correo, "UQ__Admin__2A586E0B12F03709")
                    .IsUnique();

                entity.Property(e => e.IdAdmin).HasColumnName("id_admin");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(100)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(100)
                    .HasColumnName("contraseña");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .HasColumnName("correo");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(100)
                    .HasColumnName("nombres");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Admins)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__Admin__id_rol__4CA06362");
            });

            modelBuilder.Entity<Habitacione>(entity =>
            {
                entity.HasKey(e => e.IdHabitacion)
                    .HasName("PK__Habitaci__773F28F3B5971B65");

                entity.Property(e => e.IdHabitacion).HasColumnName("id_habitacion");

                entity.Property(e => e.Capacidad).HasColumnName("capacidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .HasColumnName("estado");

                entity.Property(e => e.Numerohabitacion)
                    .HasMaxLength(10)
                    .HasColumnName("numerohabitacion");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("precio");
            });

            modelBuilder.Entity<Paquete>(entity =>
            {
                entity.HasKey(e => e.IdPaquete)
                    .HasName("PK__Paquetes__609C3BCB5A702FBB");

                entity.Property(e => e.IdPaquete).HasColumnName("id_paquete");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");

                entity.Property(e => e.IdHabitacion).HasColumnName("id_habitacion");

                entity.Property(e => e.IdServicio).HasColumnName("id_servicio");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("precio");

                entity.HasOne(d => d.IdHabitacionNavigation)
                    .WithMany(p => p.Paquetes)
                    .HasForeignKey(d => d.IdHabitacion)
                    .HasConstraintName("FK__Paquetes__id_hab__5441852A");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.Paquetes)
                    .HasForeignKey(d => d.IdServicio)
                    .HasConstraintName("FK__Paquetes__id_ser__534D60F1");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva)
                    .HasName("PK__Reservas__423CBE5DCAA3C168");

                entity.Property(e => e.IdReserva).HasColumnName("id_reserva");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("fecha_fin");

                entity.Property(e => e.FechaIni)
                    .HasColumnType("date")
                    .HasColumnName("fecha_ini");

                entity.Property(e => e.IdHabitacion).HasColumnName("id_habitacion");

                entity.Property(e => e.IdPaquete).HasColumnName("id_paquete");

                entity.Property(e => e.IdServicio).HasColumnName("id_servicio");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("total");

                entity.HasOne(d => d.IdHabitacionNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdHabitacion)
                    .HasConstraintName("FK__Reservas__id_hab__5BE2A6F2");

                entity.HasOne(d => d.IdPaqueteNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdPaquete)
                    .HasConstraintName("FK__Reservas__id_paq__5DCAEF64");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdServicio)
                    .HasConstraintName("FK__Reservas__id_ser__5CD6CB2B");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ReservasNavigation)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Reservas__id_usu__5AEE82B9");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Roles__6ABCB5E00179DB36");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.IdServicio)
                    .HasName("PK__Servicio__6FD07FDC3B246FB5");

                entity.Property(e => e.IdServicio).HasColumnName("id_servicio");

                entity.Property(e => e.Capacidad).HasColumnName("capacidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("precio");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__4E3E04AD9E1095AE");

                entity.HasIndex(e => e.Correo, "UQ__Usuarios__2A586E0B9B6166DF")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(100)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Celular).HasMaxLength(20);

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(100)
                    .HasColumnName("contraseña");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .HasColumnName("correo");

                entity.Property(e => e.EstadoReserva)
                    .HasMaxLength(50)
                    .HasColumnName("estado_reserva");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(100)
                    .HasColumnName("nombres");

                entity.Property(e => e.NroDocumento).HasMaxLength(50);

                entity.Property(e => e.Reservas).HasColumnName("reservas");

                entity.Property(e => e.TipoDocumento).HasMaxLength(50);

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__Usuarios__id_rol__5812160E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
