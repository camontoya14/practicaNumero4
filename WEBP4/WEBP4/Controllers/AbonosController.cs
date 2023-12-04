using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using WEBP4.Entities;
using WEBP4.Models;

namespace WEBP4.Controllers
{
    public class AbonosController : Controller
    {

        AbonosModel abonosModel = new AbonosModel();

        //[HttpGet]
        //public ActionResult RegistrarAbonos(AbonosEnt abonos)
        //{
        //    ViewBag.Productos = abonosModel.ConsultarProductos();

        //    long IdCompra = ViewBag.Productos.Count > 0 ? long.Parse(ViewBag.Productos[0].Value) : 0;

        //    AbonosEnt primerAbonos = new AbonosEnt { Id_Compra = IdCompra };
        //    abonos.Saldo = decimal.Parse(abonosModel.ObtenerSaldo(primerAbonos));

        //    return View(abonos);
        //}

        [HttpGet]
        public ActionResult RegistrarAbonos()
        {
            AbonosEnt abonos = new AbonosEnt();
            abonos.Productos = abonosModel.ConsultarProductos();

            return View(abonos);
        }

        [HttpPost]
        public ActionResult RegistrarAbonos(AbonosEnt abonos, string submitButton)
        {
            abonos.Productos = abonosModel.ConsultarProductos();

            if (submitButton == "Ver")
            {
                // Acceder directamente al valor seleccionado en Id_Compra
                long IdCompraSeleccionado = abonos.Id_Compra;
                abonos.principal.Saldo = decimal.Parse(abonosModel.ObtenerSaldo(new AbonosEnt { Id_Compra = IdCompraSeleccionado }));
            }
            else if (submitButton == "Abonar")
            {
                return View("ConsultarPrincipal", "Principal");
            }

            return View(abonos);
        }
    }
}