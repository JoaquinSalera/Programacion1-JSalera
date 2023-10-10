using Back;
using Back.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class FrmCliente : Form
    {
        Principal principal = new Principal();
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantInicio pantInicio = new PantInicio();
            this.Hide();
            pantInicio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void TxtDNI_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtApeC_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtNom_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

           
            cliente.NomCliente = TxtNom.Text;
            cliente.ApeCliente = TxtApeC.Text;
            cliente.DNICliente = int.Parse(TxtDNI.Text);
            principal.AgregarClientes(cliente);

            //BindingSource binf = new BindingSource(context.Clientes);

            //ListaClientes.DataSource = null;
            //ListaClientes.DisplayMember = "CB";
            //ListaClientes.DataSource = principal;

            MessageBox.Show("Cliente Agregado");

            TxtNom.Clear();
            TxtApeC.Clear();
            TxtDNI.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
