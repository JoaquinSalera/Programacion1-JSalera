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
        public int id { get; set; }
        public int NroCtaBank { get; set; }

        public double SaldoCtaBank { get; set; }

        public TipoCtaBank TipoCta { get; set; }
        public double Deposito { get; set; }
        public double Extracion { get; set; }

    }

    // DepositoCB() SaldoCtaBank = SaldoCtaBank + Deposito
    //ExtraccionCB() SaldoCtaBank = SaldoCtaBank - Extracion
}
