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
            button4 = new Button();
            button3 = new Button();
            ListaCuentasBancarias = new ListBox();
            TxtCliente = new TextBox();
            TxtApeC = new TextBox();
            TxtNumCB = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CbTipoCBan = new ComboBox();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(603, 287);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 26;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(508, 287);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 25;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            TxtCliente.Size = new Size(100, 23);
            TxtCliente.TabIndex = 23;
            TxtCliente.TextChanged += TxtDNI_TextChanged;
            // 
            // TxtApeC
            // 
            TxtApeC.Location = new Point(158, 201);
            TxtApeC.Name = "TxtApeC";
            TxtApeC.Size = new Size(100, 23);
            TxtApeC.TabIndex = 22;
            TxtApeC.TextChanged += TxtApeC_TextChanged;
            // 
            // TxtNumCB
            // 
            TxtNumCB.Location = new Point(158, 77);
            TxtNumCB.Name = "TxtNumCB";
            TxtNumCB.Size = new Size(100, 23);
            TxtNumCB.TabIndex = 21;
            TxtNumCB.TextChanged += TxtNom_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(406, 287);
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
            label4.Size = new Size(44, 15);
            label4.TabIndex = 18;
            label4.Text = "Cliente";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 77);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 16;
            label2.Text = "Número";
            label2.Click += label2_Click;
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
            CbTipoCBan.Location = new Point(158, 118);
            CbTipoCBan.Name = "CbTipoCBan";
            CbTipoCBan.Size = new Size(100, 23);
            CbTipoCBan.TabIndex = 27;
            // 
            // FrmCtaBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 337);
            Controls.Add(CbTipoCBan);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(ListaCuentasBancarias);
            Controls.Add(TxtCliente);
            Controls.Add(TxtApeC);
            Controls.Add(TxtNumCB);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCtaBank";
            Text = "FrmCtaBank";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private ListBox ListaCuentasBancarias;
        private TextBox TxtCliente;
        private TextBox TxtApeC;
        private TextBox TxtNumCB;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox CbTipoCBan;
    }
}