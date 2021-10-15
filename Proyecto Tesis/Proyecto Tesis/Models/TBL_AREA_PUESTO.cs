namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_AREA_PUESTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_AREA_PUESTO()
        {
            TBL_EMPLEADO = new HashSet<TBL_EMPLEADO>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IN_CODIGO_PUESTO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IN_CODIGO_AREA { get; set; }

        public int? IN_NUMERO_TRABAJADORES { get; set; }

        public virtual TBL_AREA TBL_AREA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_EMPLEADO> TBL_EMPLEADO { get; set; }

        public virtual TBL_PUESTO TBL_PUESTO { get; set; }
               
    }
}
