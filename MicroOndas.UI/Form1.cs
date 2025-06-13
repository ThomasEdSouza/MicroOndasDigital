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


        private Microondas _microondas;
        private CancellationTokenSource _cts;

        public Form1()
        {
            InitializeComponent();
            _microondas = new Microondas();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int tempo;
            int potencia;

            if (!int.TryParse(txtTempo.Text, out tempo) || !int.TryParse(txtPotencia.Text, out potencia))
            {
                MessageBox.Show("Informe tempo e potência válidos.");
                return;
            }

            _cts = new CancellationTokenSource();
            lblTempo.Text = "Aquecendo...";
            try
            {
                string resultado = await Task.Run(() => _microondas.IniciarAquecimento(tempo, potencia, _cts.Token));
                lblTempo.Text = resultado;
            }
            catch (OperationCanceledException)
            {
                lblTempo.Text = "Cancelado.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            lblTempo.Text = "Aquecendo rápido...";
            try
            {
                string resultado = await Task.Run(() => _microondas.InicioRapido(_cts.Token));
                lblTempo.Text = resultado;
            }
            catch (OperationCanceledException)
            {
                lblTempo.Text = "Cancelado.";
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlVisor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblVisor_Click(object sender, EventArgs e)
        {

        }
    }
}
