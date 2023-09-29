using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public enum EstadoTcred
    {
        Activa, Pausada, Bloqueada
    }
    public class TarjetaCredito
    {
        public int id { get; set; }
        public int NroTCred { get; set; }
        public EstadoTcred EstadoTC { get; set; }

    }
}
