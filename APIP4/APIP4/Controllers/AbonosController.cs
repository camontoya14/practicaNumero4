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
    }
}