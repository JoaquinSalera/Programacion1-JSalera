using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
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
        public double Saldodisponible  {  get; set; }

        public double Montodeuda { get; set; }
        public Cliente Cliente { get; set; }

        public DateTime FechaCierre {  get; set; }

        public DateTime Fechavencimiento { get; set; }

        public string Tresumn
        {
            get { return "Numero Tarjeta: " + NroTCred + "Cliente" + Cliente + "Estado: " + EstadoTC + "Monto adeudado: " + Montodeuda + "Saldo Disponible: " + Saldodisponible + "Fecha Cierre: " + FechaCierre + "Fecha Vencimiento: " + Fechavencimiento; }
        }
    }

    
}
