using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIP4.Controllers
{
    public class PrincipalController : ApiController
    {
        [HttpGet]
        [Route("ConsultarPrincipal")]
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