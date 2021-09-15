namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_BIOMETRICO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_BIOMETRICO()
        {
            TBL_CLIENTE = new HashSet<TBL_CLIENTE>();
        }

        [Key]
        public int IN_CODIGO_BIOMETRICO { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_TIPO { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_DESCRIPCION { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_NOMBRE { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_IP { get; set; }

        public int IN_CODIGO_SERVIDOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_CLIENTE> TBL_CLIENTE { get; set; }

        public virtual TBL_SERVIDOR TBL_SERVIDOR { get; set; }
    }
}
