namespace Front
{
    partial class FrmTatjetaCred
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
            ListaTCred = new ListBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // ListaTCred
            // 
            ListaTCred.FormattingEnabled = true;
            ListaTCred.ItemHeight = 15;
            ListaTCred.Location = new Point(400, 54);
            ListaTCred.Name = "ListaTCred";
            ListaTCred.Size = new Size(313, 169);
            ListaTCred.TabIndex = 24;
            ListaTCred.SelectedIndexChanged += ListaClientes_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(400, 286);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 20;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(27, 305);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 15;
            label1.Text = "TARJETAS DE CREDITO:";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 163);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 29;
            label5.Text = "Estado TC:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(152, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 121);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 31;
            label6.Text = "DNI Cliente";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 32;
            // 
            // FrmTatjetaCred
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(ListaTCred);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "FrmTatjetaCred";
            Text = "FrmTatjetaCred";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox ListaTCred;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBox1;
    }
}