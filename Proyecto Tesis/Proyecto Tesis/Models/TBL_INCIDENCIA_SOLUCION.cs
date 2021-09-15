namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_INCIDENCIA_SOLUCION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_INCIDENCIA_SOLUCION()
        {
            TBL_REGISTRO_ICNDENCIA = new HashSet<TBL_REGISTRO_ICNDENCIA>();
        }

        [Key]
        public int IN_CODIGO_INC_SOLUC { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_DECRIPCION { get; set; }

        public int IN_CODIGO_INCIDENCIA { get; set; }

        public int IN_CODIGO_SOLUCION { get; set; }

        public virtual TBL_INCIDENCIA TBL_INCIDENCIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_REGISTRO_ICNDENCIA> TBL_REGISTRO_ICNDENCIA { get; set; }

        public virtual TBL_SOLUCIONES TBL_SOLUCIONES { get; set; }
    }
}
