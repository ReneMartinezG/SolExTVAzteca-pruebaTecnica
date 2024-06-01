using BussinesNota;
using DataNotas.Models;
using DataNotas.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebExTVAzteca.Controllers
{
    public class HomeController : Controller
    {
        BusCatalogos busCatalogo = new BusCatalogos();
        BusNotas busNota = new BusNotas();

        // GET: Home
        public ActionResult Index()
        {
           List<Notas> lsN = new List<Notas>();

           lsN = busNota.ObtenerTodos();

            return View(lsN);
        }

        public ActionResult AgregarProductos(int idNota)// id de la nota
        {
            List<Catalogos> lsC = new List<Catalogos>();
            List<CompraNotasCatalogos> lsCC = new List<CompraNotasCatalogos>();
            Notas n = new Notas();
            NotasCatalogo nc = new NotasCatalogo();


            lsC = busCatalogo.ObtenerTodos();
            lsCC = busNota.ObtenerCCPorNota(idNota);
            n = busNota.ObtenerPorID(idNota);

            TempData["Total"] = n.Total;

            ViewBag.idCatalogos = new SelectList(lsC,"id", "producto");
            TempData["idNota"] = idNota;
            return View(lsCC);
        }

        public ActionResult AgregarProductosPost(CompraNotasCatalogos cc)
        {
            busNota.AgregarCC(cc);

            return RedirectToAction("AgregarProductos", new { idNota = cc.idNotas});
        }

        public ActionResult IrCatalogo()
        {
            List<Catalogos> lsC = new List<Catalogos>();
            lsC = busCatalogo.ObtenerTodos();

            return View("Catalogo",lsC);
        }

        public ActionResult IrCrearCatalogo()
        {
            return View("CrearCatalogo");
        }

        public ActionResult CrearCatalogo(Catalogos c)
        {
            busCatalogo.agregar(c);
            return RedirectToAction("IrCatalogo");
        }

        public ActionResult CrearNota()
        {
            busNota.Agregar();

            return RedirectToAction("Index");
        }

        public ActionResult FinalizarCompra(CompraNotasCatalogos cnc)
        {

            return RedirectToAction("Index");
        }


    }
}