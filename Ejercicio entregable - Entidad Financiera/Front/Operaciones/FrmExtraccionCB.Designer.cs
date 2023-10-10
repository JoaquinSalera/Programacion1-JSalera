namespace Front
{
    partial class FrmExtraccionCB
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
            label1 = new Label();
            BtnVolver = new Button();
            BtnConfi = new Button();
            TxtMontoE = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TxtCta = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "Extracción ";
            // 
            // BtnVolver
            // 
            BtnVolver.Location = new Point(50, 249);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(75, 23);
            BtnVolver.TabIndex = 13;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = true;
            // 
            // BtnConfi
            // 
            BtnConfi.Location = new Point(234, 249);
            BtnConfi.Name = "BtnConfi";
            BtnConfi.Size = new Size(75, 23);
            BtnConfi.TabIndex = 12;
            BtnConfi.Text = "Confirmar";
            BtnConfi.UseVisualStyleBackColor = true;
            // 
            // TxtMontoE
            // 
            TxtMontoE.Location = new Point(209, 140);
            TxtMontoE.Name = "TxtMontoE";
            TxtMontoE.Size = new Size(100, 23);
            TxtMontoE.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 140);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 10;
            label2.Text = "Monto a Retirar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 47);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 9;
            label3.Text = "Cuenta Bancaria";
            // 
            // TxtCta
            // 
            TxtCta.Location = new Point(176, 47);
            TxtCta.Name = "TxtCta";
            TxtCta.Size = new Size(133, 23);
            TxtCta.TabIndex = 8;
            // 
            // FrmExtraccionCB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 325);
            Controls.Add(BtnVolver);
            Controls.Add(BtnConfi);
            Controls.Add(TxtMontoE);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(TxtCta);
            Controls.Add(label1);
            Name = "FrmExtraccionCB";
            Text = "FrmExtraccionCB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnVolver;
        private Button BtnConfi;
        private TextBox TxtMontoE;
        private Label label2;
        private Label label3;
        private TextBox TxtCta;
    }
}