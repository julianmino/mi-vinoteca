namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pedidos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pedidos()
        {
            lineas_pedidos = new HashSet<lineas_pedidos>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_pedido { get; set; }

        [Required]
        [StringLength(50)]
        public string usuario { get; set; }

        public int? id_descuento { get; set; }

        public DateTime fecha { get; set; }

        [Required]
        public string observaciones { get; set; }

        public double total { get; set; }

        public virtual clientes clientes { get; set; }

        public virtual descuentos descuentos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lineas_pedidos> lineas_pedidos { get; set; }
    }
}
