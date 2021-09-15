namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_USUARIO
    {
        [Key]
        public int IN_CODIGO_USUARIO { get; set; }

        [Required]
        [StringLength(128)]
        public string VC_USUARIO { get; set; }

        [Required]
        [StringLength(128)]
        public string VC_PASSWORD { get; set; }

        [Required]
        [StringLength(1)]
        public string CH_SITUACION_REGISTRO { get; set; }

        public int? IN_CODIGO_EMPLEADO { get; set; }

        public int IN_CODIGO_ROL { get; set; }

        public virtual TBL_EMPLEADO TBL_EMPLEADO { get; set; }

        public virtual TBL_ROL TBL_ROL { get; set; }
    }
}
