using Microsoft.Win32.SafeHandles;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        public decimal resposta { get; set; }
        public decimal total { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            mais,
            menos,
            multiplicar,
            dividir
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResposta.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResposta.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResposta.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResposta.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResposta.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResposta.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResposta.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResposta.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResposta.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResposta.Text += "9";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.mais;
            total = Convert.ToDecimal(txtResposta.Text);
            txtResposta.Text = "";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.menos;
            total = Convert.ToDecimal(txtResposta.Text);
            txtResposta.Text = "";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.multiplicar;
            total = Convert.ToDecimal(txtResposta.Text);
            txtResposta.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.dividir;
            total = Convert.ToDecimal(txtResposta.Text);
            txtResposta.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResposta.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.mais:
                    resposta = total + Convert.ToDecimal(txtResposta.Text);
                    break;
                case Operacao.menos:
                    resposta = total - Convert.ToDecimal(txtResposta.Text);
                    break;
                case Operacao.multiplicar:
                    resposta = total * Convert.ToDecimal(txtResposta.Text);
                    break;
                case Operacao.dividir:
                    resposta = total / Convert.ToDecimal(txtResposta.Text);
                    break;
            }
            txtResposta.Text = Convert.ToString(resposta);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResposta.Text.Contains(","))
                txtResposta.Text += ",";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if(!txtResposta.Text.Contains("."))
                txtResposta.Text += ".";
        }
    }
}
