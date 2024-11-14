namespace UltimoSemestre
{
    partial class frmEmpregados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpregados));
            lblNome = new Label();
            lblSobrenome = new Label();
            lblCpf = new Label();
            groupBox1 = new GroupBox();
            txtCpf = new TextBox();
            txtSobrenome = new TextBox();
            txtNome = new TextBox();
            btnEnviar = new Button();
            dgvEmpregados = new DataGridView();
            btnExcluir = new Button();
            btnSalvar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpregados).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(24, 38);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(24, 71);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(86, 20);
            lblSobrenome.TabIndex = 1;
            lblSobrenome.Text = "Sobrenome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(24, 104);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(33, 20);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCpf);
            groupBox1.Controls.Add(txtSobrenome);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(lblCpf);
            groupBox1.Controls.Add(lblSobrenome);
            groupBox1.Location = new Point(12, 304);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(783, 157);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empregado";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(146, 101);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(125, 27);
            txtCpf.TabIndex = 5;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(146, 68);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(574, 27);
            txtSobrenome.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(146, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(574, 27);
            txtNome.TabIndex = 3;
            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnviar.Image = (Image)resources.GetObject("btnEnviar.Image");
            btnEnviar.ImageAlign = ContentAlignment.MiddleRight;
            btnEnviar.Location = new Point(658, 467);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(137, 66);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Cadastrar";
            btnEnviar.TextAlign = ContentAlignment.MiddleLeft;
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // dgvEmpregados
            // 
            dgvEmpregados.AllowUserToAddRows = false;
            dgvEmpregados.AllowUserToDeleteRows = false;
            dgvEmpregados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpregados.Location = new Point(12, 12);
            dgvEmpregados.Name = "dgvEmpregados";
            dgvEmpregados.ReadOnly = true;
            dgvEmpregados.RowHeadersVisible = false;
            dgvEmpregados.RowHeadersWidth = 51;
            dgvEmpregados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpregados.Size = new Size(783, 286);
            dgvEmpregados.TabIndex = 5;
            dgvEmpregados.CellClick += dgvEmpregados_CellClick;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.MiddleRight;
            btnExcluir.Location = new Point(531, 468);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(121, 65);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleLeft;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleRight;
            btnSalvar.Location = new Point(417, 468);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(108, 65);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleLeft;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmEmpregados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 545);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(dgvEmpregados);
            Controls.Add(btnEnviar);
            Controls.Add(groupBox1);
            Name = "frmEmpregados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Empregados";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpregados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private Label lblSobrenome;
        private Label lblCpf;
        private GroupBox groupBox1;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtSobrenome;
        private Button btnEnviar;
        private DataGridView dgvEmpregados;
        private Button btnExcluir;
        private Button btnSalvar;
    }
}
