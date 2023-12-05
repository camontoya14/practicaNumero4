using APIP4.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIP4.Controllers
{
    public class AbonosController : ApiController
    {
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
                        respuesta.Add(new System.Web.Mvc.SelectListItem { Value = $"{item.Id_Compra}_{item.Saldo}", Text = item.Descripcion });
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
        public string ActualizarSaldo(long Id_Compra, decimal Monto)
        {
            try
            {
                using (var context = new PracticaS12Entities())
                {
                    context.RebajarSaldo(Id_Compra, Monto);
                    return "OK";
                }
            }
            catch (Exception ex)
            {
                return "Error al realizar el abono: " + ex.Message;
            }
        }
    }
}