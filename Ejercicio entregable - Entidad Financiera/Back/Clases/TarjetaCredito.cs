using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{

    public class TarjetaCredito
    {
        public int id { get; set; }
        public int NroTCred { get; set; }
        public string EstadoTC { get; set; }
        public double Saldodisponible  {  get; set; }

        public double Montodeuda { get; set; }
        public Cliente Cliente { get; set; }
        public double LimiteTC { get; set; }

    }

    
}
