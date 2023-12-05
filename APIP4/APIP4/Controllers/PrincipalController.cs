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
    }
}