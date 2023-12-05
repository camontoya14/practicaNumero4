﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Web;
using System.Web.Mvc;
using WEBP4.Entities;

namespace WEBP4.Models
{
    public class AbonosModel
    {
        public string urlApi = ConfigurationManager.AppSettings["urlApi"];

        public List<SelectListItem> ConsultarProductos()
        {
            using (var client = new HttpClient())
            {
                string url = urlApi + "ConsultarProductos";
                var resp = client.GetAsync(url).Result;
                return resp.Content.ReadFromJsonAsync<List<SelectListItem>>().Result;
            }
        }

        public string ActualizarSaldo(long Id_Compra, decimal Monto)
        {
            using (var client = new HttpClient())
            {
                string url = urlApi + "ActualizarSaldo";
                var data = new { Id_Compra, Monto };
                var content = JsonContent.Create(data);
                var response = client.PostAsync(url, content).Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }

    }
}