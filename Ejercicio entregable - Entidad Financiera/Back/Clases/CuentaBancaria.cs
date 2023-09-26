using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public enum TipoCtaBank
    {
        Corriente, Ahorro 
    }
    public
        class CuentaBancaria
    {
        public int IdCtaBank { get; set; }
        public int NroCtaBank { get; set; }

        public double SaldoCtaBank { get; set; }

        public TipoCtaBank TipoCta { get; set; }

    }
}
