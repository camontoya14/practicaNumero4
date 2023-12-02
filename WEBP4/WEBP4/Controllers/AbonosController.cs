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

        AbonosModel abonosModel = new AbonosModel();

        [HttpGet]
        public ActionResult RegistrarAbonos()
        {

            ViewBag.Productos = abonosModel.ConsultarProductos();
            return View();

        }
    }
}
