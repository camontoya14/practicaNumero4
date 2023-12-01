using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEBP4.Controllers
{
    public class AbonosController : Controller
    {
        [HttpGet]
        public ActionResult RegistrarAbonos()
        {
            return View();
        }
    }
}
