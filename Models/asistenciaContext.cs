using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ModeloAsistencia.Models
{
    public partial class asistenciaContext : DbContext
    {
        public asistenciaContext()
        {
        }

        public asistenciaContext(DbContextOptions<asistenciaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Docente> Docentes { get; set; } = null!;
        public virtual DbSet<Grupo> Grupos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Docente>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PRIMARY");

                entity.ToTable("docentes");

                entity.Property(e => e.IdEmpleado)
                    .HasMaxLength(10)
                    .HasColumnName("idEmpleado");

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .HasColumnName("celular");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.ToTable("grupos");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Asistencia)
                    .HasMaxLength(10)
                    .HasColumnName("asistencia");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(100)
                    .HasColumnName("comentarios");

                entity.Property(e => e.Grupo1)
                    .HasMaxLength(5)
                    .HasColumnName("Grupo");

                entity.Property(e => e.Horario)
                    .HasMaxLength(17)
                    .HasColumnName("horario");

                entity.Property(e => e.IdDocente)
                    .HasMaxLength(15)
                    .HasColumnName("idDocente");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
