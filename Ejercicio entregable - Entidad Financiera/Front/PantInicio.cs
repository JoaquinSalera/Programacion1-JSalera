﻿using System;
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
    public partial class PantInicio : Form
    {
        public PantInicio()
        {
            InitializeComponent();
        }

        private void PantInicio_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            this.Hide();
            frmCliente.Show();
        }
    }
}