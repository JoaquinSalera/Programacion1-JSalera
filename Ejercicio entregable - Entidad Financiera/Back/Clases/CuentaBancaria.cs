using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Back.Clases
{

    public
        class CuentaBancaria
    {
        public int id { get; set; }
        public int NroCtaBank { get; set; }

        public double SaldoCtaBank { get; set; }

        public string TipoCta { get; set; }

        public Cliente Cliente { get; set; }

        public string CB { get { return "El numero de cuenta es: " + NroCtaBank + "Saldo: " + SaldoCtaBank + "Tipo Cta: " + TipoCta ; } }

    }


}
