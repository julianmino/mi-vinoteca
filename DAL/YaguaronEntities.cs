namespace DAL {
    using System.Data.Entity;

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
            }
        }
    }
