using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjetoDesktop
{
    public partial class Form1 : Form
    {
        public int segundos;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTextar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá c-sharp lindão!");
            MessageBox.Show($"Ola {textNome.Text}", "Boas Vindas!");
            MessageBox.Show($"Ola {textNome.Text}", "Boas Vindas!", MessageBoxButtons.OKCancel);
            MessageBox.Show($"Ola {textNome.Text}", "Boas Vindas!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtN1.Text);
            double valor2 = Convert.ToDouble(textN2.Text);
            double resultado = valor1 + valor2;
            txtN3.Text = resultado.ToString();
        }

        private void tempoSegundos_Tick(object sender, EventArgs e)
        {
            segundos += 1;
            labelSegundos.Text = segundos.ToString();
        }

        private void botaoStart_Click(object sender, EventArgs e)
        {
            tempoSegundos.Enabled = true;
            buttonStop.Enabled = true;
            botaoStart.Enabled  = false;

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            tempoSegundos.Enabled = false;
            buttonStop.Enabled = false;
            botaoStart.Enabled = true;
            buttonzerar.Enabled = true;
            botaoStart.Text = "Continuar?";
        }

        private void buttonzerar_Click(object sender, EventArgs e)
        {
            segundos = 0;
            labelSegundos.Text = segundos.ToString();
            tempoSegundos.Enabled = false;
            botaoStart.Enabled = true;
            buttonStop.Enabled = false;
            buttonzerar.Enabled = false;
            botaoStart.Text = "start";
        }
    }
}
