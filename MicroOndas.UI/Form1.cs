using MicroOndas.Core;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroOndas.UI
{
    public partial class Form1 : Form
    {
        private Microondas microondas;
        private CancellationTokenSource _cts;
        private TextBox _campoAtivo;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            ConfigurarTeclado();
            this.Load += Form1_Load;
            microondas = new Microondas();
            lblVisor.Text = "12:00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

            _campoAtivo = txtTempo;

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
                    txtTempo.Text += numero;
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

        private void ConfigurarTeclado()
        {
            for (int i = 0; i <= 9; i++)
            {
                var botao = new Button
                {
                    Text = i.ToString(),
                    Size = new System.Drawing.Size(50, 40),
                    Location = new System.Drawing.Point((i % 3) * 60 + 10, (i / 3) * 45 + 10),
                    Name = "btnNum" + i
                };
                botao.Click += TecladoNumerico_Click;
                pnlTeclado.Controls.Add(botao);
            }
        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
