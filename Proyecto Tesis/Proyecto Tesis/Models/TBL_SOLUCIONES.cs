namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_SOLUCIONES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_SOLUCIONES()
        {
            TBL_INCIDENCIA_SOLUCION = new HashSet<TBL_INCIDENCIA_SOLUCION>();
        }

        [Key]
        public int IN_CODIGO_SOLUCION { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_NOMBRE_SOLUCION { get; set; }

        [StringLength(256)]
        public string VC_DESCRIPCION { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_ARCHIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_INCIDENCIA_SOLUCION> TBL_INCIDENCIA_SOLUCION { get; set; }
    }
}
