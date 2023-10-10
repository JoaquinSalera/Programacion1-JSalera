namespace Front
{
    partial class FrmPagarTC
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
            BtnVolver = new Button();
            BtnPagar = new Button();
            TxtMontoaP = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TxtTcred = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnVolver
            // 
            BtnVolver.Location = new Point(59, 262);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(75, 23);
            BtnVolver.TabIndex = 20;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // BtnPagar
            // 
            BtnPagar.Location = new Point(243, 262);
            BtnPagar.Name = "BtnPagar";
            BtnPagar.Size = new Size(75, 23);
            BtnPagar.TabIndex = 19;
            BtnPagar.Text = "Pagar";
            BtnPagar.UseVisualStyleBackColor = true;
            BtnPagar.Click += BtnPagar_Click;
            // 
            // TxtMontoaP
            // 
            TxtMontoaP.Location = new Point(218, 153);
            TxtMontoaP.Name = "TxtMontoaP";
            TxtMontoaP.Size = new Size(100, 23);
            TxtMontoaP.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 153);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 17;
            label2.Text = "Monto a Pagar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 60);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 16;
            label3.Text = "Tarjeta de Crédito";
            // 
            // TxtTcred
            // 
            TxtTcred.Location = new Point(185, 60);
            TxtTcred.Name = "TxtTcred";
            TxtTcred.Size = new Size(133, 23);
            TxtTcred.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 14;
            label1.Text = "Extracción ";
            // 
            // FrmPagarTC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 331);
            Controls.Add(BtnVolver);
            Controls.Add(BtnPagar);
            Controls.Add(TxtMontoaP);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(TxtTcred);
            Controls.Add(label1);
            Name = "FrmPagarTC";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnVolver;
        private Button BtnPagar;
        private TextBox TxtMontoaP;
        private Label label2;
        private Label label3;
        private TextBox TxtTcred;
        private Label label1;
    }
}