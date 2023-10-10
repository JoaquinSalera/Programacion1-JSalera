namespace Front
{
    partial class FrmDeposito
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
            TxtCBank = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtMonto = new TextBox();
            btnConfir = new Button();
            btnVolver = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // TxtCBank
            // 
            TxtCBank.Location = new Point(157, 59);
            TxtCBank.Name = "TxtCBank";
            TxtCBank.Size = new Size(133, 23);
            TxtCBank.TabIndex = 0;
            TxtCBank.TextChanged += TxtCBank_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 59);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Cuenta Bancaria";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 152);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "Monto a Depositar";
            // 
            // TxtMonto
            // 
            TxtMonto.Location = new Point(190, 152);
            TxtMonto.Name = "TxtMonto";
            TxtMonto.Size = new Size(100, 23);
            TxtMonto.TabIndex = 4;
            // 
            // btnConfir
            // 
            btnConfir.Location = new Point(215, 261);
            btnConfir.Name = "btnConfir";
            btnConfir.Size = new Size(75, 23);
            btnConfir.TabIndex = 5;
            btnConfir.Text = "Confirmar";
            btnConfir.UseVisualStyleBackColor = true;
            btnConfir.Click += button1_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(31, 261);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 8;
            label3.Text = "Extracciones";
            // 
            // FrmDeposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 340);
            Controls.Add(label3);
            Controls.Add(btnVolver);
            Controls.Add(btnConfir);
            Controls.Add(TxtMonto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtCBank);
            Name = "FrmDeposito";
            Text = "Prueba";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCBank;
        private Label label1;
        private Label label2;
        private TextBox TxtMonto;
        private Button btnConfir;
        private Button btnVolver;
        private Label label3;
    }
}