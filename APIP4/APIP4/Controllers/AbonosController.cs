using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIP4.Controllers
{
    public class AbonosController : ApiController
    {
        [HttpPost]
        [Route("RegistrarAbonos")]
        public string RegistrarAbonos(Abonos abonos)
        {
            using (var context = new PracticaS12Entities())
            {
                context.Abonos.Add(abonos);
                context.SaveChanges();
                return "OK";
            }
        }

        [HttpGet]
        [Route("ConsultarProductos")]
        public List<System.Web.Mvc.SelectListItem> ConsultarProductos()
        {
            try
            {
                using (var context = new PracticaS12Entities())
                {
                    var datos = (from x in context.Principal
                                 select x).ToList();

                    var respuesta = new List<System.Web.Mvc.SelectListItem>();
                    foreach (var item in datos)
                    {
                        respuesta.Add(new System.Web.Mvc.SelectListItem { Value = item.Id_Compra.ToString(), Text = item.Descripcion });
                    }

                    return respuesta;
                }
            }
            catch (Exception)
            {
                return new List<System.Web.Mvc.SelectListItem>();
            }
        }

        [HttpPost]
        [Route("ActualizarSaldo")]
        public string ActualizarSaldo(Abonos abonos)
        {
            using (var context = new PracticaS12Entities())
            {
                context.RebajarSaldo(abonos.Id_Compra, abonos.Monto);
                return "OK";
            }
        }
    }
}