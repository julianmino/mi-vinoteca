namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class YaguaronEntities : DbContext
    {
        public YaguaronEntities()
            : base("name=YaguaronEntities")
        {
        }

        public virtual DbSet<admin> admin { get; set; }
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<descuentos> descuentos { get; set; }
        public virtual DbSet<lineas_pedidos> lineas_pedidos { get; set; }
        public virtual DbSet<pedidos> pedidos { get; set; }
        public virtual DbSet<productores> productores { get; set; }
        public virtual DbSet<productos> productos { get; set; }
        public virtual DbSet<tipo_producto> tipo_producto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<clientes>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.clave)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .HasMany(e => e.pedidos)
                .WithRequired(e => e.clientes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pedidos>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<pedidos>()
                .HasMany(e => e.lineas_pedidos)
                .WithRequired(e => e.pedidos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<productores>()
                .HasMany(e => e.productos)
                .WithRequired(e => e.productores)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<productos>()
                .HasMany(e => e.descuentos)
                .WithRequired(e => e.productos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<productos>()
                .HasMany(e => e.lineas_pedidos)
                .WithRequired(e => e.productos)
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
