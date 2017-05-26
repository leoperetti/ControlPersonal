using ControlPrecios.Models;
using Datos;
using System;
using System.Web.Mvc;

namespace ControlPrecios.Controllers
{
    public class IngresosController : Controller
    {
        // GET: Ingresos
        public ActionResult Index()
        {
            if (TempData["msj"] != null)
            {
                ViewData["msj"] = TempData["msj"];
            }
            return View();
        }

        public ActionResult RegistrarIngreso(IngresoModel ingreso)
        {
            if (ingreso.Id == null)
            {
                string msjRetorno;
                Ingreso dbIngreso = new Ingreso();
                dbIngreso.ingreso = ingreso.Sueldo;
                dbIngreso.fechaIngreso = ingreso.Fecha == null ? DateTime.Today : Convert.ToDateTime(ingreso.Fecha);
                using (DbLocal context = new DbLocal())
                {
                    try
                    {
                        context.Ingresos.Add(dbIngreso);
                        context.SaveChanges();
                        msjRetorno = "Se registró exitosamente el Ingreso";
                    }
                    catch (Exception ex)
                    {
                        msjRetorno = "No se pudo registrar el Ingreso, intente de nuevo";
                    }
                    TempData["msj"] = msjRetorno;
                }
            }
            return RedirectToAction("Index");
        }
    }
}