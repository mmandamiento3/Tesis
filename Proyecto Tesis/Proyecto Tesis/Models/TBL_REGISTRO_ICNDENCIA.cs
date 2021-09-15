namespace Proyecto_Tesis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_REGISTRO_ICNDENCIA
    {
        [Key]
        public int IN_CODIGO_REGISTRO { get; set; }

        public DateTime DT_FECHA_REGISTRO { get; set; }

        public DateTime DT_FECHA_MODIFICACION { get; set; }

        public int IN_CODIGO_INCIDENCIA { get; set; }

        public int IN_CODIGO_EMPLEADO { get; set; }

        public int IN_CODIGO_MODULO { get; set; }

        public int IN_CODIGO_ACTIVIDAD { get; set; }

        public int IN_CODIGO_INC_SOLUC { get; set; }

        public virtual TBL_EMPLEADO TBL_EMPLEADO { get; set; }

        public virtual TBL_INCIDENCIA TBL_INCIDENCIA { get; set; }

        public virtual TBL_INCIDENCIA_SOLUCION TBL_INCIDENCIA_SOLUCION { get; set; }

        public virtual TBL_MODULO_ACTIVIDAD TBL_MODULO_ACTIVIDAD { get; set; }
    }
}
