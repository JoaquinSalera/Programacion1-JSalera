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



        public void RealizarDeposito(CuentaBancaria CbDeposito)
        {
            var CBencontrada = context.CuentaBancarias.Find(CbDeposito.id);
            if (CBencontrada != null)
                CBencontrada.SaldoCtaBank = CbDeposito.SaldoCtaBank;

            context.SaveChanges();
        }
        public void RealizarExtraccion(CuentaBancaria CbExtraccion)
        {
            var CBencontrada = context.CuentaBancarias.Find(CbExtraccion.id);
            if (CBencontrada != null)
                CBencontrada.SaldoCtaBank = CbExtraccion.SaldoCtaBank;

            context.SaveChanges();
        }

        public void PagarTarjetaCredito(TarjetaCredito PagarTC)
        {
            var TcEncontrada = context.TarjetaCreditos.Find(PagarTC.id);
            if (TcEncontrada != null)
                TcEncontrada.SaldoResumen = PagarTC.SaldoResumen;

            context.SaveChanges();
        }
        GenerarResumenTarjeta() :
    }
}