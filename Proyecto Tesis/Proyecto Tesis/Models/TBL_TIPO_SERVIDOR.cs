namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_TIPO_SERVIDOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_TIPO_SERVIDOR()
        {
            TBL_SERVIDOR = new HashSet<TBL_SERVIDOR>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IN_TIPO_SERVIDOR { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_NOMBRE_SERVIDOR { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_DESCRIPCION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SERVIDOR> TBL_SERVIDOR { get; set; }
    }
}
