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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            TxtUsuario.Clear();
            TxtContr.Clear();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Usuario" && TxtContr.Text == "Clave")
            {
                PantInicio pantInicio = new PantInicio();
                this.Hide();
                pantInicio.Show();

            }
            else
            {
                MessageBox.Show("Los datos ingresados no son los Correctos");
                TxtUsuario.Clear();
                TxtContr.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtUsuario.Clear();
            TxtContr.Clear();
            this.Hide();
        }
    }
}
