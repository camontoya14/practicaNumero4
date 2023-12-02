using APIP4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;

namespace APIP4.Controllers
{
    public class PrincipalController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("ConsultarPrincipal")]
        public List<Principal> ConsultarPrincipal()
        {
            using (var context = new PracticaS12Entities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Principal.ToList();
            }
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("ConsultarProductos")]
        public List<System.Web.Mvc.SelectListItem> ConsultarProductos()
        {
            try
            {
                using (var context = new PracticaS12Entities())
                {
                    var datos = (from x in context.Principal
                                 select new PrincipalEnt
                                 {
                                     Id_Compra = x.Id_Compra,
                                     Descripcion = x.Descripcion
                                 }).ToList();

                    var respuesta = new List<SelectListItem>();
                    foreach (var item in datos)
                    {
                        respuesta.Add(new SelectListItem { Value = item.Id_Compra.ToString(), Text = item.Descripcion });
                    }

                    return respuesta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}