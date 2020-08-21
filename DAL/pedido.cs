namespace DAL {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("pedidos")]
    public partial class pedido {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pedido() {
            lineas_pedidos = new HashSet<lineas_pedidos>();
            }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_pedido { get; set; }

        public int id_cliente { get; set; }

        public int? id_descuento { get; set; }

        public DateTime fecha { get; set; }

        [Required]
        public string observaciones { get; set; }

        public double total { get; set; }

        public virtual cliente cliente { get; set; }

        public virtual descuento descuento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lineas_pedidos> lineas_pedidos { get; set; }
        }
    }
