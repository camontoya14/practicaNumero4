using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web;
using System.Web.Mvc;
using WEBP4.Entities;

namespace WEBP4.Models
{
    public class AbonosModel
    {
        public string urlApi = ConfigurationManager.AppSettings["urlApi"];
        public string RegistrarAbonos(AbonosEnt entidad)
        {
            using (var client = new HttpClient())
            {
                string url = urlApi + "RegistrarAbonos";
                JsonContent contenido = JsonContent.Create(entidad);
                var resp = client.PostAsync(url, contenido).Result;
                return resp.Content.ReadFromJsonAsync<string>().Result;
            }
        }

        public List<SelectListItem> ConsultarProductos()
        {
            using (var client = new HttpClient())
            {
                string url = urlApi + "ConsultarProductos";
                var resp = client.GetAsync(url).Result;
                return resp.Content.ReadFromJsonAsync<List<SelectListItem>>().Result;
            }
        }
    }
}