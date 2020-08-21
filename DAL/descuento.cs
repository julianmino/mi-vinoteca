namespace DAL {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("descuentos")]
    public partial class descuento {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public descuento() {
            clientes = new HashSet<cliente>();
            pedidos = new HashSet<pedido>();
            }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_descuento { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_caducidad { get; set; }

        public double porcentaje { get; set; }

        public int id_producto { get; set; }

        public int? id_cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cliente> clientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pedido> pedidos { get; set; }

        public virtual producto producto { get; set; }
        }
    }
