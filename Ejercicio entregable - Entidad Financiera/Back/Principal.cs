using Back.Clases;
using Back.ConexionBD;
using System;

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

        public void EmitirTarjetaCredito(TarjetaCredito tarjetadecredito, Cliente cliente,string Tipotc)
        {
            TarjetaCredito nuevatarjeta = new TarjetaCredito();

            var NrotC = int.Parse("52430000" + cliente.DNICliente.ToString());


            nuevatarjeta.NroTCred = NrotC;
            nuevatarjeta.LimiteTC = 1500000;//ver de hacer logica para que sea un porcentaje del ingreso del cliente
            nuevatarjeta.Saldodisponible = 1500000;//ver de que sea igual al limite definido
            nuevatarjeta.EstadoTC = Tipotc; //Activa, Pausada, Bloqueada
            nuevatarjeta.Montodeuda = 0;
            context.TarjetaCreditos.Add(nuevatarjeta);
            context.SaveChanges();
        }
    


        public void CrearCuentaBancaria(CuentaBancaria cuentabancaria, Cliente cliente, string Tipo)
        {
            CuentaBancaria nuevacuentabancaria = new CuentaBancaria();
            var Nrocta = 0;
            if (cuentabancaria.TipoCta == "CuentaCorriente")
            {
                Nrocta = int.Parse("444400000000" + cliente.DNICliente.ToString());
            }
            else 
            { 
                Nrocta = int.Parse("442200000000" + cliente.DNICliente.ToString());
            }

            nuevacuentabancaria.NroCtaBank = Nrocta;
            nuevacuentabancaria.SaldoCtaBank = 0;
            nuevacuentabancaria.TipoCta = Tipo;


            context.CuentaBancarias.Add(nuevacuentabancaria);
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
            //var TcEncontrada = context.TarjetaCreditos.Find(Tcreresumen.id);
            //if (TcEncontrada != null)
            //{
            //    return Tcreresumen;


            //}
            //else { return "Cliente no encontrado"; }
            
        //}

    }
}