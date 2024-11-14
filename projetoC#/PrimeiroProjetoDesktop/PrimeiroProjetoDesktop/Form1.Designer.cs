namespace PrimeiroProjetoDesktop
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnTextar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.grpSoma = new System.Windows.Forms.GroupBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.lblN3 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.textN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.botaoStart = new System.Windows.Forms.Button();
            this.labelSegundos = new System.Windows.Forms.Label();
            this.tempoSegundos = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonzerar = new System.Windows.Forms.Button();
            this.grpSoma.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(71, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(95, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Digite o seu nome:";
            // 
            // btnTextar
            // 
            this.btnTextar.Location = new System.Drawing.Point(488, 39);
            this.btnTextar.Name = "btnTextar";
            this.btnTextar.Size = new System.Drawing.Size(75, 23);
            this.btnTextar.TabIndex = 3;
            this.btnTextar.Text = "butao";
            this.btnTextar.UseVisualStyleBackColor = true;
            this.btnTextar.Click += new System.EventHandler(this.btnTextar_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(185, 39);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(267, 20);
            this.textNome.TabIndex = 4;
            // 
            // grpSoma
            // 
            this.grpSoma.Controls.Add(this.txtN3);
            this.grpSoma.Controls.Add(this.lblN3);
            this.grpSoma.Controls.Add(this.btnSomar);
            this.grpSoma.Controls.Add(this.lblN2);
            this.grpSoma.Controls.Add(this.lblN1);
            this.grpSoma.Controls.Add(this.textN2);
            this.grpSoma.Controls.Add(this.txtN1);
            this.grpSoma.Location = new System.Drawing.Point(74, 100);
            this.grpSoma.Name = "grpSoma";
            this.grpSoma.Size = new System.Drawing.Size(489, 352);
            this.grpSoma.TabIndex = 5;
            this.grpSoma.TabStop = false;
            this.grpSoma.Text = "somando componentes";
            // 
            // txtN3
            // 
            this.txtN3.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN3.Location = new System.Drawing.Point(333, 261);
            this.txtN3.Name = "txtN3";
            this.txtN3.ReadOnly = true;
            this.txtN3.Size = new System.Drawing.Size(100, 45);
            this.txtN3.TabIndex = 6;
            this.txtN3.Text = "0";
            this.txtN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN3.Location = new System.Drawing.Point(165, 265);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(126, 39);
            this.lblN3.TabIndex = 5;
            this.lblN3.Text = "Resultado";
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(13, 178);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(278, 50);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Somar Agora";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.Location = new System.Drawing.Point(6, 128);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(285, 39);
            this.lblN2.TabIndex = 3;
            this.lblN2.Text = "Digite o segundo Numero";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.Location = new System.Drawing.Point(6, 65);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(290, 39);
            this.lblN1.TabIndex = 2;
            this.lblN1.Text = "Digite o primeiro Numero";
            // 
            // textN2
            // 
            this.textN2.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textN2.Location = new System.Drawing.Point(333, 124);
            this.textN2.Name = "textN2";
            this.textN2.Size = new System.Drawing.Size(100, 45);
            this.textN2.TabIndex = 1;
            this.textN2.Text = "0";
            this.textN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(333, 61);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 45);
            this.txtN1.TabIndex = 0;
            this.txtN1.Text = "0";
            this.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // botaoStart
            // 
            this.botaoStart.Location = new System.Drawing.Point(798, 100);
            this.botaoStart.Name = "botaoStart";
            this.botaoStart.Size = new System.Drawing.Size(204, 64);
            this.botaoStart.TabIndex = 6;
            this.botaoStart.Text = "start";
            this.botaoStart.UseVisualStyleBackColor = true;
            this.botaoStart.Click += new System.EventHandler(this.botaoStart_Click);
            // 
            // labelSegundos
            // 
            this.labelSegundos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSegundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSegundos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSegundos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSegundos.Location = new System.Drawing.Point(1049, 111);
            this.labelSegundos.Name = "labelSegundos";
            this.labelSegundos.Size = new System.Drawing.Size(194, 39);
            this.labelSegundos.TabIndex = 7;
            this.labelSegundos.Text = "0";
            this.labelSegundos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempoSegundos
            // 
            this.tempoSegundos.Interval = 1000;
            this.tempoSegundos.Tick += new System.EventHandler(this.tempoSegundos_Tick);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(798, 170);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(204, 66);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonzerar
            // 
            this.buttonzerar.Enabled = false;
            this.buttonzerar.Location = new System.Drawing.Point(798, 242);
            this.buttonzerar.Name = "buttonzerar";
            this.buttonzerar.Size = new System.Drawing.Size(204, 60);
            this.buttonzerar.TabIndex = 9;
            this.buttonzerar.Text = "zerar";
            this.buttonzerar.UseVisualStyleBackColor = true;
            this.buttonzerar.Click += new System.EventHandler(this.buttonzerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1376, 504);
            this.Controls.Add(this.buttonzerar);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelSegundos);
            this.Controls.Add(this.botaoStart);
            this.Controls.Add(this.grpSoma);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.btnTextar);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpSoma.ResumeLayout(false);
            this.grpSoma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnTextar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.GroupBox grpSoma;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.TextBox textN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button botaoStart;
        private System.Windows.Forms.Label labelSegundos;
        private System.Windows.Forms.Timer tempoSegundos;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonzerar;
    }
}

