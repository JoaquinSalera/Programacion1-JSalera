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
            var clienteencontrado = context.Clientes.Find(ClienteModificado.IdCliente);
            if (clienteencontrado != null)
                clienteencontrado.DNICliente = ClienteModificado.DNICliente;
            context.SaveChanges();
        }

    }
}