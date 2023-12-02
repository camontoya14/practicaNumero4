using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web;
using WEBP4.Entities;

namespace WEBP4.Models
{
    public class PrincipalModel
    {
        public string urlApi = ConfigurationManager.AppSettings["urlApi"];
        public List<PrincipalEnt> ConsultarPrincipal()
        {
            using (var client = new HttpClient())
            {
                var url = urlApi + "ConsultarPrincipal";
                var res = client.GetAsync(url).Result;
                return res.Content.ReadFromJsonAsync<List<PrincipalEnt>>().Result;
            }
        }
    }
}