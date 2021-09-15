namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_AREA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_AREA()
        {
            TBL_AREA_PUESTO = new HashSet<TBL_AREA_PUESTO>();
        }

        [Key]
        public int IN_CODIGO_AREA { get; set; }

        [Required]
        [StringLength(128)]
        public string VC_NOMBRE_AREA { get; set; }

        public int IN_CODIGO_RESPONSABLE { get; set; }

        [Required]
        [StringLength(1)]
        public string CH_SITUACION_REGISTRO { get; set; }

        public int IN_CODIGO_COMPANIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_AREA_PUESTO> TBL_AREA_PUESTO { get; set; }

        public virtual TBL_COMPANIA TBL_COMPANIA { get; set; }
    }
}
