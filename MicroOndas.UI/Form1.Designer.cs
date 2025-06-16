namespace MicroOndas.UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.Button btnIniciarAquecimento;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblVisor;
        private System.Windows.Forms.Panel pnlVisor;
        private System.Windows.Forms.Panel pnlTeclado;
        private System.Windows.Forms.GroupBox grpProgramas;
        private System.Windows.Forms.Button btnPipoca;
        private System.Windows.Forms.Button btnRefeicao;
        private System.Windows.Forms.Button btnDescongelar;

        private System.Windows.Forms.Button bt00;
        private System.Windows.Forms.Button bt01;
        private System.Windows.Forms.Button bt02;
        private System.Windows.Forms.Button bt03;
        private System.Windows.Forms.Button bt04;
        private System.Windows.Forms.Button bt05;
        private System.Windows.Forms.Button bt06;
        private System.Windows.Forms.Button bt07;
        private System.Windows.Forms.Button bt08;
        private System.Windows.Forms.Button bt09;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.btnIniciarAquecimento = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblVisor = new System.Windows.Forms.Label();
            this.pnlVisor = new System.Windows.Forms.Panel();
            this.pnlTeclado = new System.Windows.Forms.Panel();
            this.grpProgramas = new System.Windows.Forms.GroupBox();
            this.btnPipoca = new System.Windows.Forms.Button();
            this.btnRefeicao = new System.Windows.Forms.Button();
            this.btnDescongelar = new System.Windows.Forms.Button();
            this.bt00 = new System.Windows.Forms.Button();
            this.bt01 = new System.Windows.Forms.Button();
            this.bt02 = new System.Windows.Forms.Button();
            this.bt03 = new System.Windows.Forms.Button();
            this.bt04 = new System.Windows.Forms.Button();
            this.bt05 = new System.Windows.Forms.Button();
            this.bt06 = new System.Windows.Forms.Button();
            this.bt07 = new System.Windows.Forms.Button();
            this.bt08 = new System.Windows.Forms.Button();
            this.bt09 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlVisor.SuspendLayout();
            this.grpProgramas.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(30, 30);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(80, 20);
            this.txtTempo.TabIndex = 0;
            this.toolTip4.SetToolTip(this.txtTempo, "Insira o tempo entre 1 e 300");
            // 
            // lblTempo
            // 
            this.lblTempo.Location = new System.Drawing.Point(30, 10);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(50, 20);
            this.lblTempo.TabIndex = 1;
            this.lblTempo.Text = "Tempo:";
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(130, 30);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(80, 20);
            this.txtPotencia.TabIndex = 2;
            this.toolTip5.SetToolTip(this.txtPotencia, "Insira Potência entre 1 e 10");
            // 
            // lblPotencia
            // 
            this.lblPotencia.Location = new System.Drawing.Point(130, 10);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(60, 20);
            this.lblPotencia.TabIndex = 3;
            this.lblPotencia.Text = "Potência:";
            // 
            // btnIniciarAquecimento
            // 
            this.btnIniciarAquecimento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIniciarAquecimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarAquecimento.Location = new System.Drawing.Point(230, 25);
            this.btnIniciarAquecimento.Name = "btnIniciarAquecimento";
            this.btnIniciarAquecimento.Size = new System.Drawing.Size(80, 30);
            this.btnIniciarAquecimento.TabIndex = 4;
            this.btnIniciarAquecimento.Text = "▶️ Início";
            this.toolTip1.SetToolTip(this.btnIniciarAquecimento, "Enter");
            this.btnIniciarAquecimento.UseVisualStyleBackColor = false;
            this.btnIniciarAquecimento.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancela.Location = new System.Drawing.Point(320, 25);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(80, 30);
            this.btnCancela.TabIndex = 5;
            this.btnCancela.Text = "❌ Cancelar";
            this.toolTip2.SetToolTip(this.btnCancela, "Esc");
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(410, 25);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 30);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "🧹 Limpar";
            this.toolTip2.SetToolTip(this.btnLimpar, "Ctrl + L");
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblVisor
            // 
            this.lblVisor.BackColor = System.Drawing.Color.Black;
            this.lblVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVisor.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisor.ForeColor = System.Drawing.Color.Cyan;
            this.lblVisor.Location = new System.Drawing.Point(0, 0);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(456, 46);
            this.lblVisor.TabIndex = 0;
            this.lblVisor.Text = "12:00";
            this.lblVisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlVisor
            // 
            this.pnlVisor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVisor.Controls.Add(this.lblVisor);
            this.pnlVisor.Location = new System.Drawing.Point(30, 70);
            this.pnlVisor.Name = "pnlVisor";
            this.pnlVisor.Size = new System.Drawing.Size(460, 50);
            this.pnlVisor.TabIndex = 7;
            // 
            // pnlTeclado
            // 
            this.pnlTeclado.BackColor = System.Drawing.SystemColors.Window;
            this.pnlTeclado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTeclado.Location = new System.Drawing.Point(30, 140);
            this.pnlTeclado.Name = "pnlTeclado";
            this.pnlTeclado.Size = new System.Drawing.Size(214, 212);
            this.pnlTeclado.TabIndex = 8;
            // 
            // grpProgramas
            // 
            this.grpProgramas.Controls.Add(this.btnPipoca);
            this.grpProgramas.Controls.Add(this.btnRefeicao);
            this.grpProgramas.Controls.Add(this.btnDescongelar);
            this.grpProgramas.Location = new System.Drawing.Point(269, 140);
            this.grpProgramas.Name = "grpProgramas";
            this.grpProgramas.Size = new System.Drawing.Size(200, 150);
            this.grpProgramas.TabIndex = 9;
            this.grpProgramas.TabStop = false;
            // 
            // btnPipoca
            // 
            this.btnPipoca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPipoca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPipoca.ForeColor = System.Drawing.Color.Black;
            this.btnPipoca.Location = new System.Drawing.Point(20, 30);
            this.btnPipoca.Name = "btnPipoca";
            this.btnPipoca.Size = new System.Drawing.Size(75, 23);
            this.btnPipoca.TabIndex = 0;
            this.btnPipoca.Text = "🍿 Pipoca";
            this.btnPipoca.UseVisualStyleBackColor = false;
            this.btnPipoca.Click += new System.EventHandler(this.btnPipoca_Click_1);
            // 
            // btnRefeicao
            // 
            this.btnRefeicao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefeicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefeicao.Location = new System.Drawing.Point(119, 30);
            this.btnRefeicao.Name = "btnRefeicao";
            this.btnRefeicao.Size = new System.Drawing.Size(75, 23);
            this.btnRefeicao.TabIndex = 1;
            this.btnRefeicao.Text = "🍽️ Refeição";
            this.btnRefeicao.UseVisualStyleBackColor = false;
            this.btnRefeicao.Click += new System.EventHandler(this.btnRefeicao_Click);
            // 
            // btnDescongelar
            // 
            this.btnDescongelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDescongelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescongelar.Location = new System.Drawing.Point(60, 69);
            this.btnDescongelar.Name = "btnDescongelar";
            this.btnDescongelar.Size = new System.Drawing.Size(93, 23);
            this.btnDescongelar.TabIndex = 2;
            this.btnDescongelar.Text = "❄️ Descongelar";
            this.btnDescongelar.UseVisualStyleBackColor = false;
            this.btnDescongelar.Click += new System.EventHandler(this.btnDescongelar_Click);
            // 
            // bt00
            // 
            this.bt00.Location = new System.Drawing.Point(0, 0);
            this.bt00.Name = "bt00";
            this.bt00.Size = new System.Drawing.Size(75, 23);
            this.bt00.TabIndex = 0;
            this.bt00.Text = "0";
            // 
            // bt01
            // 
            this.bt01.Location = new System.Drawing.Point(0, 0);
            this.bt01.Name = "bt01";
            this.bt01.Size = new System.Drawing.Size(75, 23);
            this.bt01.TabIndex = 0;
            this.bt01.Text = "1";
            // 
            // bt02
            // 
            this.bt02.Location = new System.Drawing.Point(0, 0);
            this.bt02.Name = "bt02";
            this.bt02.Size = new System.Drawing.Size(75, 23);
            this.bt02.TabIndex = 0;
            this.bt02.Text = "2";
            // 
            // bt03
            // 
            this.bt03.Location = new System.Drawing.Point(0, 0);
            this.bt03.Name = "bt03";
            this.bt03.Size = new System.Drawing.Size(75, 23);
            this.bt03.TabIndex = 0;
            this.bt03.Text = "3";
            // 
            // bt04
            // 
            this.bt04.Location = new System.Drawing.Point(0, 0);
            this.bt04.Name = "bt04";
            this.bt04.Size = new System.Drawing.Size(75, 23);
            this.bt04.TabIndex = 0;
            this.bt04.Text = "4";
            // 
            // bt05
            // 
            this.bt05.Location = new System.Drawing.Point(0, 0);
            this.bt05.Name = "bt05";
            this.bt05.Size = new System.Drawing.Size(75, 23);
            this.bt05.TabIndex = 0;
            this.bt05.Text = "5";
            // 
            // bt06
            // 
            this.bt06.Location = new System.Drawing.Point(0, 0);
            this.bt06.Name = "bt06";
            this.bt06.Size = new System.Drawing.Size(75, 23);
            this.bt06.TabIndex = 0;
            this.bt06.Text = "6";
            // 
            // bt07
            // 
            this.bt07.Location = new System.Drawing.Point(0, 0);
            this.bt07.Name = "bt07";
            this.bt07.Size = new System.Drawing.Size(75, 23);
            this.bt07.TabIndex = 0;
            this.bt07.Text = "7";
            // 
            // bt08
            // 
            this.bt08.Location = new System.Drawing.Point(0, 0);
            this.bt08.Name = "bt08";
            this.bt08.Size = new System.Drawing.Size(75, 23);
            this.bt08.TabIndex = 0;
            this.bt08.Text = "8";
            // 
            // bt09
            // 
            this.bt09.Location = new System.Drawing.Point(0, 0);
            this.bt09.Name = "bt09";
            this.bt09.Size = new System.Drawing.Size(75, 23);
            this.bt09.TabIndex = 0;
            this.bt09.Text = "9";
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(530, 380);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.btnIniciarAquecimento);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pnlVisor);
            this.Controls.Add(this.pnlTeclado);
            this.Controls.Add(this.grpProgramas);
            this.Name = "Form1";
            this.Text = "Microondas Digital";
            this.Load += new System.EventHandler(this.Form1_Load_2);
            this.pnlVisor.ResumeLayout(false);
            this.grpProgramas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
    }
}