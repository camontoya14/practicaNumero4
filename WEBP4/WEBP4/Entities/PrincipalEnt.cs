﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBP4.Entities
{
    public class PrincipalEnt
    {
        public long Id_Compra { get; set; }
        public decimal Precio { get; set; }
        public decimal Saldo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public AbonosEnt abonosEnt { get; set; }
    }
}