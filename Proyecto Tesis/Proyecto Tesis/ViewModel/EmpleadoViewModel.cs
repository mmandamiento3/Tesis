using Proyecto_Tesis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Tesis.ViewModel
{
      
    public class EmpleadoViewModel
    {

        TesisDBContext db = new TesisDBContext();
        public List<TBL_EMPLEADO> Empleado { get; set; }
        //public List<TBL_AREA_PUESTO> AreaPuesto { get; set; }
        //public List<TBL_AREA> Areas { get; set; }
        //public List<TBL_PUESTO> Puestos { get; set; }

    }
}