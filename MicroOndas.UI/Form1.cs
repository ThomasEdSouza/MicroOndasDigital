using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroOndas.Core;
using System.Threading;

namespace MicroOndas.UI
{
    public partial class Form1 : Form
    {
        private Microondas microondas;
        private CancellationTokenSource _cts;
        private TextBox _campoAtivo; // <- Novo campo

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            microondas = new Microondas();
            lblVisor.Text = "12:00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Atribuir todos os botões numéricos ao mesmo evento
            bt00.Click += TecladoNumerico_Click;
            bt01.Click += TecladoNumerico_Click;
            bt02.Click += TecladoNumerico_Click;
            bt03.Click += TecladoNumerico_Click;
            bt04.Click += TecladoNumerico_Click;
            bt05.Click += TecladoNumerico_Click;
            bt06.Click += TecladoNumerico_Click;
            bt07.Click += TecladoNumerico_Click;
            bt08.Click += TecladoNumerico_Click;
            bt09.Click += TecladoNumerico_Click;

            // Garante que txtTempo seja o campo padrão
            _campoAtivo = txtTempo;

            // Atribui os eventos Enter dos TextBox
            txtTempo.Enter += txtTempo_Enter;
            txtPotencia.Enter += txtPotencia_Enter;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTempo.Text, out int tempo) && int.TryParse(txtPotencia.Text, out int potencia))
            {
                microondas.DefinirTempo(tempo);
                microondas.DefinirPotencia(potencia);
                microondas.IniciarAquecimento((texto) =>
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => lblVisor.Text = texto));
                    }
                    else
                    {
                        lblVisor.Text = texto;
                    }
                });
            }
            else
            {
                MessageBox.Show("Insira tempo e potência válidos.");
            }
        }

        private async void btnCancela_Click(object sender, EventArgs e)
        {
            microondas.CancelarAquecimento();
            lblVisor.Text = "Cancelando...";

            await Task.Delay(2000);

            lblVisor.Text = "12:00";
        }

        private void TecladoNumerico_Click(object sender, EventArgs e)
        {
            if (sender is Button botao)
            {
                string numero = botao.Text;

                if (_campoAtivo != null)
                {
                    _campoAtivo.Text += numero;
                }
                else
                {
                    txtTempo.Text += numero; // padrão
                }
            }
        }

        private void txtTempo_Enter(object sender, EventArgs e)
        {
            _campoAtivo = txtTempo;
        }

        private void txtPotencia_Enter(object sender, EventArgs e)
        {
            _campoAtivo = txtPotencia;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTempo.Text = "";
            txtPotencia.Text = "";
            lblVisor.Text = "12:00";
        }
        private void btnPipoca_Click_1(object sender, EventArgs e)
        {
            txtTempo.Text = "180"; 
            txtPotencia.Text = "8";
        }
        private void btnRefeicao_Click(object sender, EventArgs e)
        {
            txtTempo.Text = "300";
            txtPotencia.Text = "10";
        }
        private void btnDescongelar_Click(object sender, EventArgs e)
        {
            txtTempo.Text = "240"; 
            txtPotencia.Text = "3";
        }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void pnlVisor_Paint(object sender, PaintEventArgs e) { }
        private void lblVisor_Click(object sender, EventArgs e) { }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
