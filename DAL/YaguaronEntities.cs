namespace DAL {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class YaguaronEntities : DbContext {
        public YaguaronEntities()
            : base("name=YaguaronEntities") {
            }

        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<cliente> clientes { get; set; }
        public virtual DbSet<descuento> descuentos { get; set; }
        public virtual DbSet<lineas_pedidos> lineas_pedidos { get; set; }
        public virtual DbSet<pedido> pedidos { get; set; }
        public virtual DbSet<producto> productos { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tipo_producto> tipo_producto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<cliente>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.clave)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .HasMany(e => e.pedidos)
                .WithRequired(e => e.cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pedido>()
                .HasMany(e => e.lineas_pedidos)
                .WithRequired(e => e.pedido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<producto>()
                .HasMany(e => e.descuentos)
                .WithRequired(e => e.producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<producto>()
                .HasMany(e => e.lineas_pedidos)
                .WithRequired(e => e.producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tipo_producto>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<tipo_producto>()
                .HasMany(e => e.productos)
                .WithRequired(e => e.tipo_producto)
                .WillCascadeOnDelete(false);
            }
        }
    }
