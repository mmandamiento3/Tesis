namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_CLIENTE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IN_CODIGO_COMPANIA { get; set; }

        public int IN_CODIGO_MODULO { get; set; }

        public int IN_CODIGO_ACTIVIDAD { get; set; }

        [Required]
        [StringLength(64)]
        public string VC_TIPO_ACCESO { get; set; }

        public int IN_CODIGO_SERVIDOR { get; set; }

        public int IN_CODIGO_BIOMETRICO { get; set; }

        public virtual TBL_BIOMETRICO TBL_BIOMETRICO { get; set; }

        public virtual TBL_COMPANIA TBL_COMPANIA { get; set; }

        public virtual TBL_MODULO_ACTIVIDAD TBL_MODULO_ACTIVIDAD { get; set; }

        public virtual TBL_SERVIDOR TBL_SERVIDOR { get; set; }
    }
}
