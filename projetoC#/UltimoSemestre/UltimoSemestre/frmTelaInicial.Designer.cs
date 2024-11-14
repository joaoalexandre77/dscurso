namespace UltimoSemestre
{
    partial class frmTelaInicial
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
            menuStrip1 = new MenuStrip();
            aRQUIVOToolStripMenuItem = new ToolStripMenuItem();
            cADASTROToolStripMenuItem = new ToolStripMenuItem();
            fUNCIONARIOSToolStripMenuItem = new ToolStripMenuItem();
            cLIENTESToolStripMenuItem = new ToolStripMenuItem();
            sOBREToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aRQUIVOToolStripMenuItem, cADASTROToolStripMenuItem, sOBREToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aRQUIVOToolStripMenuItem
            // 
            aRQUIVOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            aRQUIVOToolStripMenuItem.Name = "aRQUIVOToolStripMenuItem";
            aRQUIVOToolStripMenuItem.Size = new Size(70, 20);
            aRQUIVOToolStripMenuItem.Text = "ARQUIVO";
            // 
            // cADASTROToolStripMenuItem
            // 
            cADASTROToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fUNCIONARIOSToolStripMenuItem, cLIENTESToolStripMenuItem });
            cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            cADASTROToolStripMenuItem.Size = new Size(79, 20);
            cADASTROToolStripMenuItem.Text = "CADASTRO";
            // 
            // fUNCIONARIOSToolStripMenuItem
            // 
            fUNCIONARIOSToolStripMenuItem.Name = "fUNCIONARIOSToolStripMenuItem";
            fUNCIONARIOSToolStripMenuItem.Size = new Size(159, 22);
            fUNCIONARIOSToolStripMenuItem.Text = "FUNCIONARIOS";
            fUNCIONARIOSToolStripMenuItem.Click += fUNCIONARIOSToolStripMenuItem_Click;
            // 
            // cLIENTESToolStripMenuItem
            // 
            cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            cLIENTESToolStripMenuItem.Size = new Size(159, 22);
            cLIENTESToolStripMenuItem.Text = "CLIENTES";
            cLIENTESToolStripMenuItem.Click += cLIENTESToolStripMenuItem_Click;
            // 
            // sOBREToolStripMenuItem
            // 
            sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
            sOBREToolStripMenuItem.Size = new Size(54, 20);
            sOBREToolStripMenuItem.Text = "SOBRE";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // frmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmTelaInicial";
            Text = "frmTelaInicial";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aRQUIVOToolStripMenuItem;
        private ToolStripMenuItem cADASTROToolStripMenuItem;
        private ToolStripMenuItem fUNCIONARIOSToolStripMenuItem;
        private ToolStripMenuItem cLIENTESToolStripMenuItem;
        private ToolStripMenuItem sOBREToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}