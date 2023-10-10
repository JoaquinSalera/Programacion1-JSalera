namespace Front
{
    partial class FrmCtaBank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListaCuentasBancarias = new ListBox();
            TxtCliente = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            CbTipoCBan = new ComboBox();
            SuspendLayout();
            // 
            // ListaCuentasBancarias
            // 
            ListaCuentasBancarias.FormattingEnabled = true;
            ListaCuentasBancarias.ItemHeight = 15;
            ListaCuentasBancarias.Location = new Point(406, 55);
            ListaCuentasBancarias.Name = "ListaCuentasBancarias";
            ListaCuentasBancarias.Size = new Size(313, 169);
            ListaCuentasBancarias.TabIndex = 24;
            ListaCuentasBancarias.SelectedIndexChanged += ListaClientes_SelectedIndexChanged;
            // 
            // TxtCliente
            // 
            TxtCliente.Location = new Point(158, 164);
            TxtCliente.Name = "TxtCliente";
            TxtCliente.Size = new Size(145, 23);
            TxtCliente.TabIndex = 22;
            TxtCliente.TextChanged += TxtApeC_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(406, 265);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 20;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(33, 306);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 167);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 18;
            label4.Text = " DNI Cliente";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 118);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 17;
            label3.Text = "Tipo";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 22);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 15;
            label1.Text = "CUENTAS BANCARIAS:";
            label1.Click += label1_Click;
            // 
            // CbTipoCBan
            // 
            CbTipoCBan.FormattingEnabled = true;
            CbTipoCBan.Items.AddRange(new object[] { "CuentaCorriente", "Caja De Ahorro" });
            CbTipoCBan.Location = new Point(158, 118);
            CbTipoCBan.Name = "CbTipoCBan";
            CbTipoCBan.Size = new Size(145, 23);
            CbTipoCBan.TabIndex = 27;
            CbTipoCBan.SelectedIndexChanged += CbTipoCBan_SelectedIndexChanged;
            // 
            // FrmCtaBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 337);
            Controls.Add(CbTipoCBan);
            Controls.Add(ListaCuentasBancarias);
            Controls.Add(TxtCliente);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FrmCtaBank";
            Text = "FrmCtaBank";
            Load += FrmCtaBank_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private ListBox ListaCuentasBancarias;
        private TextBox TxtCliente;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox CbTipoCBan;
        private ComboBox CboxCliente;
    }
}