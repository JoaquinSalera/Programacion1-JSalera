﻿using Back;
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
    public partial class FrmTatjetaCred : Form
    {
        Principal principal = new Principal();
        public FrmTatjetaCred()
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
            TarjetaCredito tarjetaCredito = new TarjetaCredito();
            //tarjetaCredito.EstadoTC = comboBox1;
            //tarjetaCredito.Cliente =;


            ListaTCred.DataSource = null;
            ListaTCred.DisplayMember = "Tresumn";
            ListaTCred.DataSource = principal;

            MessageBox.Show("Tarjeta Creada");

            





        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
