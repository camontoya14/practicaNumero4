using System;
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
        public ActionResult RegistrarAbonos(AbonosEnt a)
        {
            ViewBag.Productos = abonosModel.ConsultarProductos();
            return View();
        }
    }
}
