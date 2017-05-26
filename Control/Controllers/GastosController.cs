using ControlPrecios.Models;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlPrecios.Controllers
{
    public class GastosController : Controller
    {
        // GET: Operaciones
        public ActionResult Index(GastosModel modelo)
        {

            if(TempData["msj"] != null)
            {
            ViewData["msj"] = TempData["msj"];
            }
            if(modelo != null)
            {
                GastosModel model = new GastosModel();
                model.Comercios = GetComercios();
                return View(model);
            }
            return View();
        }

        public ActionResult CargarGasto(GastosModel gasto)
        {
            if (gasto.Id == null)
            {
                string msjRetorno;
                Gasto dbGasto = new Gasto();
                dbGasto.cantidadDinero = gasto.Dinero;
                dbGasto.cantidadProductos = gasto.Productos;
                dbGasto.fechaGasto = gasto.Fecha == null ? DateTime.Today : Convert.ToDateTime(gasto.Fecha);
                dbGasto.tipoComercioFK = gasto.IdTipoComercio;
                using (DbLocal context = new DbLocal())
                {
                    try
                    {
                        context.Gastos.Add(dbGasto);
                        context.SaveChanges();
                        msjRetorno = "Se registró exitosamente el Gasto";
                    }
                    catch(Exception)
                    {
                        msjRetorno = "No se pudo registrar el Gasto, intente de nuevo";
                    }
                }
                TempData["msj"] = msjRetorno;
            }
            return RedirectToAction("Index");
        }

        public ActionResult CargarComercio(Comercios comercio)
        {
            if(comercio.IdTipoComercio == null)
            {
                string msjRetorno;
                Comercio dbcomercio = new Comercio();
                dbcomercio.descripcion = comercio.TipoComercio;
                dbcomercio.habilitado = Convert.ToByte(comercio.Habilitado);
                using (DbLocal context = new DbLocal())
                {
                    try
                    {
                        context.Comercios.Add(dbcomercio);
                        context.SaveChanges();
                    }
                    catch(Exception)
                    {
                        msjRetorno = "No se pudo cargar el Comercio, intente de nuevo";
                    }
                    msjRetorno = "Se cargó correctamente el nuevo registro";
                }
                TempData["msj"] = msjRetorno;
            }
            return RedirectToAction("Index");
        }


        private IEnumerable<SelectListItem> GetComercios()
        {
            using (DbLocal context = new DbLocal())
            {
                var comercios = context.Set<Comercio>().ToList();
                List<Comercios> comer = new List<Comercios>();
                foreach(var c in comercios)
                {
                    Comercios com = new Comercios();
                    com.IdTipoComercio = c.Id;
                    com.TipoComercio = c.descripcion;
                    com.Habilitado = c.habilitado == 1 ? true : false;
                    comer.Add(com);
                }
                return (new SelectList(comer, "IdTipoComercio", "TipoComercio"));
            }
        }
    }
}