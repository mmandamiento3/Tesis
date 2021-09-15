namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_INCIDENCIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_INCIDENCIA()
        {
            TBL_REGISTRO_ICNDENCIA = new HashSet<TBL_REGISTRO_ICNDENCIA>();
            TBL_INCIDENCIA_SOLUCION = new HashSet<TBL_INCIDENCIA_SOLUCION>();
        }

        [Key]
        public int IN_CODIGO_INCIDENCIA { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_NOMBRE_INCIDENCIA { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_DESCRIPCION { get; set; }

        public int IN_TIPO_INCIDENCIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_REGISTRO_ICNDENCIA> TBL_REGISTRO_ICNDENCIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_INCIDENCIA_SOLUCION> TBL_INCIDENCIA_SOLUCION { get; set; }

        public virtual TBL_TIPO_INCIDENCIA TBL_TIPO_INCIDENCIA { get; set; }
    }
}
