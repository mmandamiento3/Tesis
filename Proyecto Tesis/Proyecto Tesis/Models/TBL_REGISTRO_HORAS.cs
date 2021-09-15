namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_REGISTRO_HORAS
    {
        [Key]
        public int IN_CODIGO_REGISTRO { get; set; }

        public DateTime DT_FECHA_REGISTRO { get; set; }

        public decimal DE_HORAS { get; set; }

        public int IN_CODIGO_EMPLEADO { get; set; }

        public int IN_CODIGO_COMPANIA { get; set; }

        public int IN_CODIGO_MODULO { get; set; }

        public int IN_CODIGO_ACTIVIDAD { get; set; }

        public virtual TBL_COMPANIA TBL_COMPANIA { get; set; }

        public virtual TBL_EMPLEADO TBL_EMPLEADO { get; set; }

        public virtual TBL_MODULO_ACTIVIDAD TBL_MODULO_ACTIVIDAD { get; set; }
    }
}
