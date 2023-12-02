using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBP4.Models;

namespace WEBP4.Controllers
{
    public class AbonosController : Controller
    {

        PrincipalController principalModelito = new PrincipalController();

        [HttpGet]
        public ActionResult RegistrarAbonos()
        {
            return View();
        }

        [HttpGet]
        public ActionResult MostrarPrincipal()
        {
            long Id_Compra = long.Parse(Session["Id_Compra"].ToString());
            ViewBag.Productos = principalModelito.ConsultarPrincipal();
            var datos = principalModelito.ConsultarPrincipal();
            return View(datos);
        }
    }
}
