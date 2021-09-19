using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto_Tesis.Models;

namespace Proyecto_Tesis.Controllers
{
    public class EmpleadoController : Controller
    {
        private TesisDBContext db = new TesisDBContext();

        // GET: Empleado
        public ActionResult Index()
        {
            var tBL_EMPLEADO = db.TBL_EMPLEADO.Include(t => t.TBL_AREA_PUESTO);
            return View(tBL_EMPLEADO.ToList());
        }

        // GET: Empleado/Details/5
        public ActionResult Details(int? id)
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

        // GET: Empleado/Create
        public ActionResult Create()
        {
            ViewBag.IN_CODIGO_PUESTO = new SelectList(db.TBL_AREA_PUESTO, "IN_CODIGO_PUESTO", "IN_CODIGO_PUESTO");
            return View();
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

            ViewBag.IN_CODIGO_PUESTO = new SelectList(db.TBL_AREA_PUESTO, "IN_CODIGO_PUESTO", "IN_CODIGO_PUESTO", tBL_EMPLEADO.IN_CODIGO_PUESTO);
            return View(tBL_EMPLEADO);
        }

        // GET: Empleado/Edit/5
        public ActionResult Edit(int? id)
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
            ViewBag.IN_CODIGO_PUESTO = new SelectList(db.TBL_AREA_PUESTO, "IN_CODIGO_PUESTO", "IN_CODIGO_PUESTO", tBL_EMPLEADO.IN_CODIGO_PUESTO);
            return View(tBL_EMPLEADO);
        }

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
