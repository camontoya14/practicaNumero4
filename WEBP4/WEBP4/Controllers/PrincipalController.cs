using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBP4.Models;

namespace WEBP4.Controllers
{
    public class PrincipalController : Controller
    {
        PrincipalModel principalModel = new PrincipalModel();

        [HttpGet]
        public ActionResult ConsultarPrincipal()
        {
            var datos = principalModel.ConsultarPrincipal();
            return View(datos);
        }

    
    }
}