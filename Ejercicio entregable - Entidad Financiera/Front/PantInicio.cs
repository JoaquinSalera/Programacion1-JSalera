using Front.Operaciones;
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

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            this.Hide();
            frmCliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tARJETACREDITOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPagarTC frmPagarTC = new FrmPagarTC();
            this.Hide();
            frmPagarTC.Show();
        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTatjetaCred frmTatjetaCred = new FrmTatjetaCred();
            this.Hide();
            frmTatjetaCred.Show();
        }

        private void aBMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCtaBank frmCtaBank = new FrmCtaBank();
            this.Hide();
            frmCtaBank.Show();
        }

        private void depósitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeposito frmDeposito = new FrmDeposito();
            this.Hide();
            frmDeposito.Show();
        }

        private void extraccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExtraccionCB frmExtraccionCB = new FrmExtraccionCB();
            this.Hide();
            frmExtraccionCB.Show();
        }

        private void consultaSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaSaldo frmConsultaSaldo = new FrmConsultaSaldo();
            this.Hide();
            frmConsultaSaldo.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
