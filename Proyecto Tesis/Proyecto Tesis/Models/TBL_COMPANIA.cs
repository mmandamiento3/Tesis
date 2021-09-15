namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_COMPANIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_COMPANIA()
        {
            TBL_AREA = new HashSet<TBL_AREA>();
            TBL_REGISTRO_HORAS = new HashSet<TBL_REGISTRO_HORAS>();
        }

        [Key]
        public int IN_CODIGO_COMPANIA { get; set; }

        [Required]
        [StringLength(146)]
        public string VC_NOMBRE { get; set; }

        [Required]
        [StringLength(64)]
        public string VC_RUC { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_DIRECCION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_AREA> TBL_AREA { get; set; }

        public virtual TBL_CLIENTE TBL_CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_REGISTRO_HORAS> TBL_REGISTRO_HORAS { get; set; }
    }
}
