using NewCalculadora.Controller;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace NewCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double valor;
        double valor2;
        int opcao = 0;
        bool igual;
        Controle controle = new Controle();


        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                valor = Convert.ToDouble(txtTela.Text);
                txtTela.Text += " + ";
                opcao = 1;
            }
            catch (FormatException erroFormatException)
            {
                MessageBox.Show("Erro de formatação: " + erroFormatException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erroInesperado)
            {
                MessageBox.Show("Erro inesperado: " + erroInesperado.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNumberOne_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtTela.Clear();
                txtTela.Text += 1;
                igual = false;
            }
            else
            {
                txtTela.Text += 1;
            }
        }

        private void btnNumberTwo_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtTela.Clear();
                txtTela.Text += 2;
                igual = false;
            }
            else
            {
                txtTela.Text += 2;
            }
        }

        private void btnNumberThree_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtTela.Clear();
                txtTela.Text += 3;
                igual = false;
            }
            else
            {
                txtTela.Text += 3;
            }
        }

        private void btnNumberFour_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtTela.Clear();
                txtTela.Text += 4;
                igual = false;
            }
            else
            {
                txtTela.Text += 4;
            }
        }

        private void btnNumberFive_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtTela.Clear();
                txtTela.Text += 5;
                igual = false;
            }
            else
            {
                txtTela.Text += 5;
            }
        }

        private void btnNumberSix_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtTela.Clear();
                txtTela.Text += 6;
                igual = false;
            }
            else
            {
                txtTela.Text += 6;
            }
        }

        private void btnNumberSeven_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtTela.Clear();
                txtTela.Text += 7;
                igual = false;
            }
            else
            {
                txtTela.Text += 7;
            }
        }

        private void btnNumberEight_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtTela.Clear();
                txtTela.Text += 8;
                igual = false;
            }
            else
            {
                txtTela.Text += 8;
            }
        }

        private void btnNumberNine_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtTela.Clear();
                txtTela.Text += 9;
                igual = false;
            }
            else
            {
                txtTela.Text += 9;
            }
        }

        private void btnNumberZero_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtTela.Clear();
                txtTela.Text += 0;
                igual = false;
            }
            else
            {
                txtTela.Text += 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                txtTela.Clear();
                txtTela.Text += ',';
                igual = false;
            }
            else
            {
                txtTela.Text += ',';
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {

                String[] vetor = txtTela.Text.Split(' ');
                valor2 = Convert.ToDouble(vetor[2]);
                switch (opcao)
                {
                    case 1:
                        txtTela.Clear();
                        txtTela.Text = controle.Soma(valor, valor2).ToString("F2", CultureInfo.InvariantCulture);
                        break;
                    case 2:
                        txtTela.Clear();
                        txtTela.Text = controle.Sub(valor, valor2).ToString("F2", CultureInfo.InvariantCulture);
                        break;
                    case 3:
                        if (valor2 == 0)
                        {
                            txtTela.Text = "Não é possível dividir por zero";
                        }
                        else
                        {
                            txtTela.Clear();
                            txtTela.Text = controle.Div(valor, valor2).ToString("F2", CultureInfo.InvariantCulture);
                        }

                        break;
                    case 4:
                        txtTela.Clear();
                        txtTela.Text = controle.Mult(valor, valor2).ToString("F2", CultureInfo.InvariantCulture);
                        break;
                    default:
                        break;
                }
                opcao = 0;
                igual = true;

            }
            catch (Exception error)
            {
                MessageBox.Show("Erro inesperado: " + error.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtTela.Clear();
            valor = 0;
            valor2 = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtTela.Clear();
            valor = 0;
            valor2 = 0;
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                valor = Convert.ToDouble(txtTela.Text);
                txtTela.Text += " - ";
                opcao = 2;
            }
            catch (FormatException erroFormatException)
            {
                MessageBox.Show("Erro de formatação: " + erroFormatException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erroInesperado)
            {
                MessageBox.Show("Erro inesperado: " + erroInesperado.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMultiplicate_Click(object sender, EventArgs e)
        {
            try
            {
                valor = Convert.ToDouble(txtTela.Text);
                txtTela.Text += " x ";
                opcao = 4;
            }
            catch (FormatException erroFormatacao)
            {
                MessageBox.Show("Erro de formatação: " + erroFormatacao.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro inesperado: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                valor = Convert.ToDouble(txtTela.Text);
                txtTela.Text += " / ";
                opcao = 3;
            }
            catch (FormatException formatacao)
            {
                MessageBox.Show("Erro de formatação: " + formatacao.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro inesperado: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
            double numero = Convert.ToDouble(txtTela.Text);
            txtTela.Text = "";
            txtTela.Text = controle.ConverterSinal(numero).ToString("F2", CultureInfo.InvariantCulture);

            }
            catch (FormatException errorFormat)
            {
                MessageBox.Show("Error de formataçaõ: " + errorFormat.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro inesperado: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
            int cortar = txtTela.Text.IndexOf(txtTela.Text);
            String recortarUltimoCaracter = txtTela.Text.Remove(txtTela.Text.Length - 1);
            txtTela.Text = recortarUltimoCaracter;

            }
            catch (FormatException errorFormat)
            {
                MessageBox.Show("Error de formataçaõ: " + errorFormat.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro inesperado: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
