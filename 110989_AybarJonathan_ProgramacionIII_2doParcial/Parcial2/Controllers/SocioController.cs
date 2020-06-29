using Parcial2.AccesoDatos;
using Parcial2.Models;
using Parcial2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial2.Controllers
{
    public class SocioController : Controller
    {
        // GET: Socio
        public ActionResult AltaSocio()
        {
            List<TipoDocumentoItemVM> listaTipoDocumento = AccesoDB.obtenerListaTipoDocumento();
            List<DeporteItemVM> listaDeportes = AccesoDB.obtenerListaDeportes();

            List<SelectListItem> itemsTipoDocumento = listaTipoDocumento.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.Nombre,
                    Value = d.Id.ToString(),
                    Selected = false
                };
            });

            ViewBag.ItemsTipoDocumento = itemsTipoDocumento;

            List<SelectListItem> itemsDeportes = listaDeportes.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.Nombre,
                    Value = d.Id.ToString(),
                    Selected = false
                };
            });

            ViewBag.ItemsDeportes = itemsDeportes;

            return View();
        }

        [HttpPost]
        public ActionResult AltaSocio(Socio modelo)
        {
            if (ModelState.IsValid)
            {
                bool resultado = AccesoDB.AltaSocio(modelo);
                if (resultado)
                {
                    
                    return RedirectToAction("ListadoSocios", "Socio");
                }
                else
                {
                    return View(modelo);
                }
            }
            else
            {
                return View(modelo);
            }
        }

        public ActionResult ListadoSocios()
        {
            List<Socio> lista = AccesoDB.obtenerListaSocios();
            return View(lista);
        }

        public ActionResult Reporte()
        {
            List<Reporte> lista = AccesoDB.obtenerReporte();
            return View(lista);
        }
    }
}