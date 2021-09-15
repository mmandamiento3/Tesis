namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_SERVIDOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_SERVIDOR()
        {
            TBL_BIOMETRICO = new HashSet<TBL_BIOMETRICO>();
            TBL_CLIENTE = new HashSet<TBL_CLIENTE>();
        }

        [Key]
        public int IN_CODIGO_SERVIDOR { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_DESCRIPCION { get; set; }

        public decimal DE_CAPACIDAD_DD { get; set; }

        public decimal DE_CAPACIDAD_RAM { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_MODELO { get; set; }

        public DateTime? DT_ANHO { get; set; }

        public int IN_TIPO_SERVIDOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_BIOMETRICO> TBL_BIOMETRICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_CLIENTE> TBL_CLIENTE { get; set; }

        public virtual TBL_TIPO_SERVIDOR TBL_TIPO_SERVIDOR { get; set; }
    }
}
