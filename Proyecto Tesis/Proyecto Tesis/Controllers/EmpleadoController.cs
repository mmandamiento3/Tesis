using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto_Tesis.Models;
using Proyecto_Tesis.ViewModel;

namespace Proyecto_Tesis.Controllers
{
    public class EmpleadoController : Controller
    {
        private TesisDBContext db = new TesisDBContext();
        

        // GET: Empleado
        public ActionResult Index()
        {
            
            EmpleadoViewModel obj = new EmpleadoViewModel();
            //obj.AreaPuesto = db.TBL_AREA_PUESTO.ToList();
            //obj.Areas = db.TBL_AREA.ToList();
            //obj.Puestos = db.TBL_PUESTO.ToList();           
            obj.Empleado = db.TBL_EMPLEADO.Include(m=>m.TBL_AREA_PUESTO).ToList();
            
            
            //List<TBL_EMPLEADO> lista3 = new List<TBL_EMPLEADO>();
            ////original: 
            //var empleado = db.TBL_EMPLEADO.Include(t => t.TBL_AREA_PUESTO);

            ////lista3.AddRange(empleado);
            //return View(emp.ListarEmpleado());
            //---------------------------------------------------------------------------------
            return View(obj);
            
        }

      

        // GET: Empleado/Details/5
        public ActionResult Details(int? id)
        {

            EmpleadoViewModel obj2 = new EmpleadoViewModel();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //TBL_EMPLEADO tBL_EMPLEADO = db.TBL_EMPLEADO.Find(id);
            obj2.Empleado = db.TBL_EMPLEADO.Include(m => m.TBL_AREA_PUESTO).Where(xx => xx.IN_CODIGO_EMPLEADO == id).ToList();
           
            if (obj2 == null)
            {
                return HttpNotFound();
            }
            return View(obj2);
        }


        List<SelectListItem> lista2 = new List<SelectListItem>(); //cbo areas
        List<SelectListItem> listasexo = new List<SelectListItem>();
        List<SelectListItem> TipodeDocumento = new List<SelectListItem>();

        // GET: Empleado/Create
        public ActionResult Create()
        {    

          
            lista2 = (from ap in db.TBL_AREA_PUESTO.GroupBy(p => p.IN_CODIGO_AREA).Select(g => g.FirstOrDefault()) //esto para evitar los datos duplicados
                      join a in db.TBL_AREA on ap.IN_CODIGO_AREA equals a.IN_CODIGO_AREA
                      where ap.IN_CODIGO_AREA == a.IN_CODIGO_AREA

                      select new SelectListItem
                      {
                          Value = ap.IN_CODIGO_AREA.ToString(),
                          Text = a.VC_NOMBRE_AREA

                      }).ToList();

            ViewBag.ListaArea2 = lista2;

            ////Lista de sexo : Femenimo y MAsculino
            listasexo.Add(new SelectListItem() { Text = "Masculino", Value = "1" });
            listasexo.Add(new SelectListItem() { Text = "Femenino", Value = "2" });
            ViewBag.Sexo = listasexo;

            //Lista de Tipo de Documento
            TipodeDocumento.Add(new SelectListItem() { Text = "DNI", Value = "1" });
            TipodeDocumento.Add(new SelectListItem() { Text = "Pasaporte", Value = "2" });
            TipodeDocumento.Add(new SelectListItem() { Text = "Carnet Extranjería", Value = "3" });
            ViewBag.TipoDocumento = TipodeDocumento;
           

            //--------------------------------//

            return View();
        }

        public JsonResult ObtenerPuesto2(int area)
        {
         
            var lista1 = (from ap in db.TBL_AREA_PUESTO join p in db.TBL_PUESTO on ap.IN_CODIGO_PUESTO equals p.IN_CODIGO_PUESTO
                      where ap.IN_CODIGO_PUESTO == p.IN_CODIGO_PUESTO && ap.IN_CODIGO_AREA == area
                      select new SelectListItem
                      {
                          Value = ap.IN_CODIGO_PUESTO.ToString(),
                          Text = p.VC_NOMBRE_PUESTO

                      }).ToList();
            

            return Json(lista1,JsonRequestBehavior.AllowGet);
        }




        // POST: Empleado/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IN_CODIGO_EMPLEADO,VC_APELLIDO_PATERNO,VC_APELLIDO_MATERNO,VC_NOMBRES,CH_SEXO,DT_FECHA_NACIMIENTO,VC_NACIONALIDAD,CH_TIPO_DOCUMENTO,VC_NUMERO_DOCUMENTO,VC_CORREO,VC_NUMERO_CELULAR,CH_SITUACION_REGISTRO,VC_FOTO,IN_CODIGO_PUESTO,IN_CODIGO_AREA")] TBL_EMPLEADO tBL_EMPLEADO)
        {

          

            if (ModelState.IsValid)
            {
                db.TBL_EMPLEADO.Add(tBL_EMPLEADO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

     
 
            //ViewBag.IN_CODIGO_PUESTO = new SelectList(db.TBL_PUESTO, "IN_CODIGO_PUESTO", "IN_CODIGO_PUESTO", tBL_EMPLEADO.IN_CODIGO_PUESTO);
            //ViewBag.IN_CODIGO_AREA = new SelectList(db.TBL_AREA, "IN_CODIGO_AREA", "IN_CODIGO_AREA", tBL_EMPLEADO.IN_CODIGO_AREA);
            return View(tBL_EMPLEADO);       
    }

        
        
        
        
        
        // GET: Empleado/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    TBL_EMPLEADO tBL_EMPLEADO = db.TBL_EMPLEADO.Find(id);
        //    if (tBL_EMPLEADO == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.IN_CODIGO_PUESTO = new SelectList(db.TBL_AREA_PUESTO, "IN_CODIGO_PUESTO", "IN_CODIGO_PUESTO", tBL_EMPLEADO.IN_CODIGO_PUESTO);
        //    return View(tBL_EMPLEADO);
        //}

        // POST: Empleado/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IN_CODIGO_EMPLEADO,VC_APELLIDO_PATERNO,VC_APELLIDO_MATERNO,VC_NOMBRES,CH_SEXO,DT_FECHA_NACIMIENTO,VC_NACIONALIDAD,CH_TIPO_DOCUMENTO,VC_NUMERO_DOCUMENTO,VC_CORREO,VC_NUMERO_CELULAR,CH_SITUACION_REGISTRO,VC_FOTO,IN_CODIGO_PUESTO,IN_CODIGO_AREA")] TBL_EMPLEADO tBL_EMPLEADO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_EMPLEADO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IN_CODIGO_PUESTO = new SelectList(db.TBL_AREA_PUESTO, "IN_CODIGO_PUESTO", "IN_CODIGO_PUESTO", tBL_EMPLEADO.IN_CODIGO_PUESTO);
            return View(tBL_EMPLEADO);
        }

        // GET: Empleado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_EMPLEADO tBL_EMPLEADO = db.TBL_EMPLEADO.Find(id);
            if (tBL_EMPLEADO == null)
            {
                return HttpNotFound();
            }
            return View(tBL_EMPLEADO);
        }

        // POST: Empleado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TBL_EMPLEADO tBL_EMPLEADO = db.TBL_EMPLEADO.Find(id);
            db.TBL_EMPLEADO.Remove(tBL_EMPLEADO);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
