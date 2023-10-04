using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public enum TipoCtaBank
    {
        Cta_Corriente, Caja_Ahorro
    }
    public
        class CuentaBancaria
    {
        public int id { get; set; }
        public int NroCtaBank { get; set; }

        public double SaldoCtaBank { get; set; }

        public TipoCtaBank TipoCta { get; set; }

        public Cliente Cliente { get; set; }


    }


}
