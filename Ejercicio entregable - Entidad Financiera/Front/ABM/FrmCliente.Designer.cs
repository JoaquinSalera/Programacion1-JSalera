namespace Front
{
    partial class FrmCliente
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            TxtNom = new TextBox();
            TxtApeC = new TextBox();
            TxtDNI = new TextBox();
            ListaClientes = new ListBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 121);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Apellido";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 80);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 25);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 3;
            label1.Text = "Clientes:";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 170);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 6;
            label4.Text = "DNI";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(36, 309);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(409, 290);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TxtNom
            // 
            TxtNom.Location = new Point(161, 80);
            TxtNom.Name = "TxtNom";
            TxtNom.Size = new Size(100, 23);
            TxtNom.TabIndex = 9;
            TxtNom.TextChanged += TxtNom_TextChanged;
            // 
            // TxtApeC
            // 
            TxtApeC.Location = new Point(161, 121);
            TxtApeC.Name = "TxtApeC";
            TxtApeC.Size = new Size(100, 23);
            TxtApeC.TabIndex = 10;
            TxtApeC.TextChanged += TxtApeC_TextChanged;
            // 
            // TxtDNI
            // 
            TxtDNI.Location = new Point(161, 167);
            TxtDNI.Name = "TxtDNI";
            TxtDNI.Size = new Size(100, 23);
            TxtDNI.TabIndex = 11;
            TxtDNI.TextChanged += TxtDNI_TextChanged;
            // 
            // ListaClientes
            // 
            ListaClientes.FormattingEnabled = true;
            ListaClientes.ItemHeight = 15;
            ListaClientes.Location = new Point(409, 58);
            ListaClientes.Name = "ListaClientes";
            ListaClientes.Size = new Size(313, 169);
            ListaClientes.TabIndex = 12;
            ListaClientes.SelectedIndexChanged += ListaClientes_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(511, 290);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(606, 290);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 14;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(ListaClientes);
            Controls.Add(TxtDNI);
            Controls.Add(TxtApeC);
            Controls.Add(TxtNom);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox TxtNom;
        private TextBox TxtApeC;
        private TextBox TxtDNI;
        private ListBox ListaClientes;
        private Button button3;
        private Button button4;
    }
}