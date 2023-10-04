using Back.Clases;
using Back.ConexionBD;

namespace Back
{
    public class Principal
    {
        AplicationBDContext context = new AplicationBDContext();

        public void AgregarClientes(Cliente clienteNuevo)
        {
            context.Clientes.Add(clienteNuevo);
            context.SaveChanges();
        }
        public void EliminarClientes(int IdCliente)
        {
            var clienteencontrado = context.Clientes.Find(IdCliente);
            if (clienteencontrado != null)
                context.Clientes.Remove(clienteencontrado);
            context.SaveChanges();
        }
        public void ModificarClientes(Cliente ClienteModificado)
        {
            var clienteencontrado = context.Clientes.Find(ClienteModificado.id);
            if (clienteencontrado != null)
                clienteencontrado.DNICliente = ClienteModificado.DNICliente;

            context.SaveChanges();
        }
        public void EmitirTarjetaCredito(TarjetaCredito tarjetadecredito)
        {
            context.TarjetaCreditos.Add(tarjetadecredito);
            context.SaveChanges();
        }


        public void CrearCuentaBancaria(CuentaBancaria cuentabancaria)
        {
            context.CuentaBancarias.Add(cuentabancaria);
            context.SaveChanges();
        }


        public void PausarTarjetaCredito(TarjetaCredito TCcambioestado)
        {
            var TCencontrada = context.TarjetaCreditos.Find(TCcambioestado.id);
            if (TCencontrada != null)
                TCencontrada.EstadoTC = TCcambioestado.EstadoTC;

            context.SaveChanges();
        }


        public void RealizarExtraccion(CuentaBancaria CbExtraccion, double MontoExtr)
        {
            var CBencontrada = context.CuentaBancarias.Find(CbExtraccion.id);
            if (CBencontrada != null)
                CBencontrada.SaldoCtaBank = CbExtraccion.SaldoCtaBank - MontoExtr;

            context.SaveChanges();
        }
        public void RealizarDeposito(CuentaBancaria CbExtraccion, double Montodep)
        {
            var CBencontrada = context.CuentaBancarias.Find(CbExtraccion.id);
            if (CBencontrada != null)
                CBencontrada.SaldoCtaBank = CbExtraccion.SaldoCtaBank + Montodep;

            context.SaveChanges();
        }
        public void PagarTarjetaCredito(TarjetaCredito PagarTC,double Monto)
        {
            var TcEncontrada = context.TarjetaCreditos.Find(PagarTC.id);
            if (TcEncontrada != null)
                TcEncontrada.Montodeuda = PagarTC.Montodeuda -  Monto;
                TcEncontrada.Saldodisponible = PagarTC.Saldodisponible + Monto;

            context.SaveChanges();
        }


       //public string GenerarResumenTarjeta(TarjetaCredito Tcreresumen)
       //{
       //     var TcEncontrada = context.TarjetaCreditos.Find(Tcreresumen.id);
       //     if (TcEncontrada != null)
       //         return Tcreresumen.Tresumn;
       //     context.SaveChanges();
       // }

    }
}