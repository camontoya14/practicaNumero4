using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIP4.Entities
{
    public class AbonosEnt
    {
        public long Id_Compra { get; set; }
        public long Id_Abono { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}