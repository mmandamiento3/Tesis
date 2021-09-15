namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_MODULO_ACTIVIDAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_MODULO_ACTIVIDAD()
        {
            TBL_CLIENTE = new HashSet<TBL_CLIENTE>();
            TBL_REGISTRO_HORAS = new HashSet<TBL_REGISTRO_HORAS>();
            TBL_REGISTRO_ICNDENCIA = new HashSet<TBL_REGISTRO_ICNDENCIA>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IN_CODIGO_MODULO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IN_CODIGO_ACTIVIDAD { get; set; }

        [Required]
        [StringLength(1)]
        public string IN_TIPO { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_MANUAL_ACCESO { get; set; }

        public virtual TBL_ACTIVIDAD TBL_ACTIVIDAD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_CLIENTE> TBL_CLIENTE { get; set; }

        public virtual TBL_MODULO TBL_MODULO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_REGISTRO_HORAS> TBL_REGISTRO_HORAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_REGISTRO_ICNDENCIA> TBL_REGISTRO_ICNDENCIA { get; set; }
    }
}
