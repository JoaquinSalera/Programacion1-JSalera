namespace Front
{
    partial class PantInicio
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
            menuStrip1 = new MenuStrip();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            cLIENTESToolStripMenuItem = new ToolStripMenuItem();
            tARJETACREDITOToolStripMenuItem = new ToolStripMenuItem();
            aBMToolStripMenuItem = new ToolStripMenuItem();
            consultaResumenToolStripMenuItem = new ToolStripMenuItem();
            pagarToolStripMenuItem = new ToolStripMenuItem();
            cUENTABANCARIAToolStripMenuItem = new ToolStripMenuItem();
            aBMToolStripMenuItem1 = new ToolStripMenuItem();
            consultaSaldoToolStripMenuItem = new ToolStripMenuItem();
            extraccionToolStripMenuItem = new ToolStripMenuItem();
            depósitoToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(691, 198);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clienteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cLIENTESToolStripMenuItem, tARJETACREDITOToolStripMenuItem, cUENTABANCARIAToolStripMenuItem });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(54, 20);
            clienteToolStripMenuItem.Text = "INICIO";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // cLIENTESToolStripMenuItem
            // 
            cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            cLIENTESToolStripMenuItem.Size = new Size(180, 22);
            cLIENTESToolStripMenuItem.Text = "CLIENTES";
            cLIENTESToolStripMenuItem.Click += cLIENTESToolStripMenuItem_Click;
            // 
            // tARJETACREDITOToolStripMenuItem
            // 
            tARJETACREDITOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aBMToolStripMenuItem, consultaResumenToolStripMenuItem, pagarToolStripMenuItem });
            tARJETACREDITOToolStripMenuItem.Name = "tARJETACREDITOToolStripMenuItem";
            tARJETACREDITOToolStripMenuItem.Size = new Size(180, 22);
            tARJETACREDITOToolStripMenuItem.Text = "TARJETA CREDITO";
            tARJETACREDITOToolStripMenuItem.Click += tARJETACREDITOToolStripMenuItem_Click;
            // 
            // aBMToolStripMenuItem
            // 
            aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            aBMToolStripMenuItem.Size = new Size(173, 22);
            aBMToolStripMenuItem.Text = "ABM";
            aBMToolStripMenuItem.Click += aBMToolStripMenuItem_Click;
            // 
            // consultaResumenToolStripMenuItem
            // 
            consultaResumenToolStripMenuItem.Name = "consultaResumenToolStripMenuItem";
            consultaResumenToolStripMenuItem.Size = new Size(173, 22);
            consultaResumenToolStripMenuItem.Text = "Consulta Resumen";
            // 
            // pagarToolStripMenuItem
            // 
            pagarToolStripMenuItem.Name = "pagarToolStripMenuItem";
            pagarToolStripMenuItem.Size = new Size(173, 22);
            pagarToolStripMenuItem.Text = "Pagar";
            pagarToolStripMenuItem.Click += pagarToolStripMenuItem_Click;
            // 
            // cUENTABANCARIAToolStripMenuItem
            // 
            cUENTABANCARIAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aBMToolStripMenuItem1, consultaSaldoToolStripMenuItem, extraccionToolStripMenuItem, depósitoToolStripMenuItem });
            cUENTABANCARIAToolStripMenuItem.Name = "cUENTABANCARIAToolStripMenuItem";
            cUENTABANCARIAToolStripMenuItem.Size = new Size(180, 22);
            cUENTABANCARIAToolStripMenuItem.Text = "CUENTA BANCARIA";
            // 
            // aBMToolStripMenuItem1
            // 
            aBMToolStripMenuItem1.Name = "aBMToolStripMenuItem1";
            aBMToolStripMenuItem1.Size = new Size(180, 22);
            aBMToolStripMenuItem1.Text = "ALTA";
            aBMToolStripMenuItem1.Click += aBMToolStripMenuItem1_Click;
            // 
            // consultaSaldoToolStripMenuItem
            // 
            consultaSaldoToolStripMenuItem.Name = "consultaSaldoToolStripMenuItem";
            consultaSaldoToolStripMenuItem.Size = new Size(180, 22);
            consultaSaldoToolStripMenuItem.Text = "Consulta Saldo";
            consultaSaldoToolStripMenuItem.Click += consultaSaldoToolStripMenuItem_Click;
            // 
            // extraccionToolStripMenuItem
            // 
            extraccionToolStripMenuItem.Name = "extraccionToolStripMenuItem";
            extraccionToolStripMenuItem.Size = new Size(180, 22);
            extraccionToolStripMenuItem.Text = "Extraccion";
            extraccionToolStripMenuItem.Click += extraccionToolStripMenuItem_Click;
            // 
            // depósitoToolStripMenuItem
            // 
            depósitoToolStripMenuItem.Name = "depósitoToolStripMenuItem";
            depósitoToolStripMenuItem.Size = new Size(180, 22);
            depósitoToolStripMenuItem.Text = "Depósito";
            depósitoToolStripMenuItem.Click += depósitoToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(168, 100);
            label1.Name = "label1";
            label1.Size = new Size(413, 65);
            label1.TabIndex = 9;
            label1.Text = "Entidad Financiera";
            label1.Click += label1_Click;
            // 
            // PantInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 257);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PantInicio";
            Text = "PantInicio";
            Load += PantInicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem cLIENTESToolStripMenuItem;
        private ToolStripMenuItem tARJETACREDITOToolStripMenuItem;
        private ToolStripMenuItem aBMToolStripMenuItem;
        private ToolStripMenuItem consultaResumenToolStripMenuItem;
        private ToolStripMenuItem pagarToolStripMenuItem;
        private ToolStripMenuItem cUENTABANCARIAToolStripMenuItem;
        private ToolStripMenuItem aBMToolStripMenuItem1;
        private ToolStripMenuItem consultaSaldoToolStripMenuItem;
        private ToolStripMenuItem extraccionToolStripMenuItem;
        private ToolStripMenuItem depósitoToolStripMenuItem;
        private Label label1;
    }
}