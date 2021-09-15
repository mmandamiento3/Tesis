namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_EMPLEADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_EMPLEADO()
        {
            TBL_REGISTRO_HORAS = new HashSet<TBL_REGISTRO_HORAS>();
            TBL_REGISTRO_ICNDENCIA = new HashSet<TBL_REGISTRO_ICNDENCIA>();
            TBL_USUARIO = new HashSet<TBL_USUARIO>();
        }

        [Key]
        public int IN_CODIGO_EMPLEADO { get; set; }

        [Required]
        [StringLength(256)]
        public string VC_APELLIDO_PATERNO { get; set; }

        [Required]
        [StringLength(128)]
        public string VC_APELLIDO_MATERNO { get; set; }

        [Required]
        [StringLength(10)]
        public string VC_NOMBRES { get; set; }

        [Required]
        [StringLength(1)]
        public string CH_SEXO { get; set; }

        public DateTime DT_FECHA_NACIMIENTO { get; set; }

        [Required]
        [StringLength(128)]
        public string VC_NACIONALIDAD { get; set; }

        [Required]
        [StringLength(1)]
        public string CH_TIPO_DOCUMENTO { get; set; }

        [Required]
        [StringLength(10)]
        public string VC_NUMERO_DOCUMENTO { get; set; }

        [StringLength(256)]
        public string VC_CORREO { get; set; }

        [StringLength(16)]
        public string VC_NUMERO_CELULAR { get; set; }

        [Required]
        [StringLength(1)]
        public string CH_SITUACION_REGISTRO { get; set; }

        [StringLength(156)]
        public string VC_FOTO { get; set; }

        public int IN_CODIGO_PUESTO { get; set; }

        public int IN_CODIGO_AREA { get; set; }

        public virtual TBL_AREA_PUESTO TBL_AREA_PUESTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_REGISTRO_HORAS> TBL_REGISTRO_HORAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_REGISTRO_ICNDENCIA> TBL_REGISTRO_ICNDENCIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_USUARIO> TBL_USUARIO { get; set; }
    }
}
