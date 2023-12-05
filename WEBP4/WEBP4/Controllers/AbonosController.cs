using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Web.Mvc;
using WEBP4.Entities;
using WEBP4.Models;

namespace WEBP4.Controllers
{
    public class AbonosController : Controller
    {

        AbonosModel abonosModel = new AbonosModel();

        [HttpGet]
        public ActionResult RegistrarAbonos()
        {
            ViewBag.Productos = abonosModel.ConsultarProductos();
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarAbonos(AbonosEnt abonos)
        {

            ViewBag.Productos = abonosModel.ConsultarProductos();

            if (abonos.Id_Compra != 0 && abonos.Monto > 0)
            {
                string resultadoAbono = abonosModel.ActualizarSaldo(abonos.Id_Compra, abonos.Monto);
                ViewBag.MensajeUsuario = resultadoAbono;
            }

            return View(abonos);
        }
    }
}