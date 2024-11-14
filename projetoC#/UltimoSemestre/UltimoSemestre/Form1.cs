using System.Windows.Forms;

namespace UltimoSemestre
{
    public partial class frmEmpregados : Form
    {
        public frmEmpregados()
        {
            InitializeComponent();
        }

        Empregado em = new Empregado();
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                em.setCpf(txtCpf.Text);
                em.setNome(txtNome.Text);
                em.setSobrenome(txtSobrenome.Text);
                em.Inserir();

            }

            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }

            dgvEmpregados.DataSource = em.Consultar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvEmpregados.Width = this.Width - 50;
            dgvEmpregados.DataSource = em.Consultar();
            dgvEmpregados.Columns[0].Visible = false;
            dgvEmpregados.Columns[1].Width = (this.Width / 100) * 40;
            dgvEmpregados.Columns[2].Width = (this.Width / 100) * 40;
            dgvEmpregados.Columns[3].Width = (this.Width / 100) * 20;

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            dgvEmpregados.Width = this.Width - 50;
            //dgvEmpregados.Columns[1].Width = (this.Width / 100) * 40;
            //dgvEmpregados.Columns[2].Width = (this.Width / 100) * 40;
            //dgvEmpregados.Columns[3].Width = (this.Width / 100) * 20;
        }

        private void dgvEmpregados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            txtNome.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            txtSobrenome.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            txtCpf.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                em.setCpf(txtCpf.Text);
                em.Excluir();
                dgvEmpregados.DataSource = em.Consultar();
            }
            finally
            {
                MessageBox.Show("O registro foi excluido com sucesso!");
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            { 
                em.setNome(txtNome.Text); // Seleciona o nome que vai ser alterado
                em.setSobrenome(txtSobrenome.Text); // O sobrenome que vai ser alterado
                em.setCpf(txtCpf.Text);//seleciona o cpf que vai ser alterado

                em.Alterar(); //chama o metodo alterar da classe Empregado
                dgvEmpregados.DataSource= em.Consultar(); //atualiza o DGV
            }
            finally
            {
                MessageBox.Show("O registro foi modificado com sucesso!");
            }
        }
    }
}
