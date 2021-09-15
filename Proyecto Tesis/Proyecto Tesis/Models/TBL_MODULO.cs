namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_MODULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_MODULO()
        {
            TBL_MODULO_ACTIVIDAD = new HashSet<TBL_MODULO_ACTIVIDAD>();
        }

        [Key]
        public int IN_CODIGO_MODULO { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_NOMBRE_MODULO { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_DESCRIPCION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_MODULO_ACTIVIDAD> TBL_MODULO_ACTIVIDAD { get; set; }
    }
}
