namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("productos")]
    public partial class producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public producto()
        {
            descuentos = new HashSet<descuento>();
            lineas_pedidos = new HashSet<lineas_pedidos>();
        }

        [Key]
        public int id_producto { get; set; }

        public double ml { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string productor { get; set; }

        public int id_tipo { get; set; }

        public double vol_alcohol { get; set; }

        public double precio { get; set; }

        public int stock { get; set; }

        public int? año { get; set; }

        public int? añejamiento { get; set; }

        public double? ibu { get; set; }

        public byte[] foto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<descuento> descuentos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lineas_pedidos> lineas_pedidos { get; set; }

        public virtual tipo_producto tipo_producto { get; set; }
    }
}
