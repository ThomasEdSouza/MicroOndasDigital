using MicroOndas.Core;

namespace MicroOndas.UI
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
            this.btnIniciarAquecimento = new System.Windows.Forms.Button();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblVisor = new System.Windows.Forms.Label();
            this.bt01 = new System.Windows.Forms.Button();
            this.bt02 = new System.Windows.Forms.Button();
            this.bt03 = new System.Windows.Forms.Button();
            this.bt04 = new System.Windows.Forms.Button();
            this.bt05 = new System.Windows.Forms.Button();
            this.bt06 = new System.Windows.Forms.Button();
            this.bt07 = new System.Windows.Forms.Button();
            this.bt08 = new System.Windows.Forms.Button();
            this.bt09 = new System.Windows.Forms.Button();
            this.bt00 = new System.Windows.Forms.Button();
            this.btnDescongelar = new System.Windows.Forms.Button();
            this.btnRefeicao = new System.Windows.Forms.Button();
            this.btnPipoca = new System.Windows.Forms.Button();
            this.pnlVisor = new System.Windows.Forms.Panel();
            this.pnlTeclado = new System.Windows.Forms.Panel();
            this.grpProgramas = new System.Windows.Forms.GroupBox();
            this.pnlVisor.SuspendLayout();
            this.pnlTeclado.SuspendLayout();
            this.grpProgramas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarAquecimento
            // 
            this.btnIniciarAquecimento.Location = new System.Drawing.Point(3, 150);
            this.btnIniciarAquecimento.Name = "btnIniciarAquecimento";
            this.btnIniciarAquecimento.Size = new System.Drawing.Size(60, 23);
            this.btnIniciarAquecimento.TabIndex = 0;
            this.btnIniciarAquecimento.Text = "Iniciar";
            this.btnIniciarAquecimento.UseVisualStyleBackColor = true;
            this.btnIniciarAquecimento.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(70, 99);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(100, 20);
            this.txtTempo.TabIndex = 1;
            this.txtTempo.Text = "Tempo";
            this.txtTempo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(12, 102);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(43, 13);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "Tempo:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Location = new System.Drawing.Point(192, 102);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(52, 13);
            this.lblPotencia.TabIndex = 4;
            this.lblPotencia.Text = "Potência:";
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(250, 99);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(100, 20);
            this.txtPotencia.TabIndex = 5;
            this.txtPotencia.Text = "Potência";
            this.txtPotencia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Início Rápido";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblVisor
            // 
            this.lblVisor.AutoSize = true;
            this.lblVisor.BackColor = System.Drawing.Color.Black;
            this.lblVisor.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVisor.Location = new System.Drawing.Point(68, 10);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(107, 37);
            this.lblVisor.TabIndex = 7;
            this.lblVisor.Text = "12:00";
            this.lblVisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVisor.Click += new System.EventHandler(this.lblVisor_Click);
            // 
            // bt01
            // 
            this.bt01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt01.Location = new System.Drawing.Point(3, 3);
            this.bt01.Name = "bt01";
            this.bt01.Size = new System.Drawing.Size(60, 40);
            this.bt01.TabIndex = 8;
            this.bt01.Text = "1";
            this.bt01.UseVisualStyleBackColor = true;
            this.bt01.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bt02
            // 
            this.bt02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt02.Location = new System.Drawing.Point(69, 3);
            this.bt02.Name = "bt02";
            this.bt02.Size = new System.Drawing.Size(60, 40);
            this.bt02.TabIndex = 9;
            this.bt02.Text = "2";
            this.bt02.UseVisualStyleBackColor = true;
            // 
            // bt03
            // 
            this.bt03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt03.Location = new System.Drawing.Point(135, 3);
            this.bt03.Name = "bt03";
            this.bt03.Size = new System.Drawing.Size(60, 40);
            this.bt03.TabIndex = 10;
            this.bt03.Text = "3";
            this.bt03.UseVisualStyleBackColor = true;
            // 
            // bt04
            // 
            this.bt04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt04.Location = new System.Drawing.Point(3, 49);
            this.bt04.Name = "bt04";
            this.bt04.Size = new System.Drawing.Size(60, 40);
            this.bt04.TabIndex = 11;
            this.bt04.Text = "4";
            this.bt04.UseVisualStyleBackColor = true;
            // 
            // bt05
            // 
            this.bt05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt05.Location = new System.Drawing.Point(69, 49);
            this.bt05.Name = "bt05";
            this.bt05.Size = new System.Drawing.Size(60, 40);
            this.bt05.TabIndex = 12;
            this.bt05.Text = "5";
            this.bt05.UseVisualStyleBackColor = true;
            // 
            // bt06
            // 
            this.bt06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt06.Location = new System.Drawing.Point(135, 49);
            this.bt06.Name = "bt06";
            this.bt06.Size = new System.Drawing.Size(60, 40);
            this.bt06.TabIndex = 13;
            this.bt06.Text = "6";
            this.bt06.UseVisualStyleBackColor = true;
            // 
            // bt07
            // 
            this.bt07.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt07.Location = new System.Drawing.Point(3, 95);
            this.bt07.Name = "bt07";
            this.bt07.Size = new System.Drawing.Size(60, 40);
            this.bt07.TabIndex = 14;
            this.bt07.Text = "7";
            this.bt07.UseVisualStyleBackColor = true;
            // 
            // bt08
            // 
            this.bt08.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt08.Location = new System.Drawing.Point(69, 95);
            this.bt08.Name = "bt08";
            this.bt08.Size = new System.Drawing.Size(60, 40);
            this.bt08.TabIndex = 15;
            this.bt08.Text = "8";
            this.bt08.UseVisualStyleBackColor = true;
            // 
            // bt09
            // 
            this.bt09.Location = new System.Drawing.Point(135, 95);
            this.bt09.Name = "bt09";
            this.bt09.Size = new System.Drawing.Size(60, 40);
            this.bt09.TabIndex = 16;
            this.bt09.Text = "9";
            this.bt09.UseVisualStyleBackColor = true;
            // 
            // bt00
            // 
            this.bt00.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt00.Location = new System.Drawing.Point(69, 141);
            this.bt00.Name = "bt00";
            this.bt00.Size = new System.Drawing.Size(60, 40);
            this.bt00.TabIndex = 17;
            this.bt00.Text = "0";
            this.bt00.UseVisualStyleBackColor = true;
            // 
            // btnDescongelar
            // 
            this.btnDescongelar.Location = new System.Drawing.Point(40, 81);
            this.btnDescongelar.Name = "btnDescongelar";
            this.btnDescongelar.Size = new System.Drawing.Size(79, 23);
            this.btnDescongelar.TabIndex = 18;
            this.btnDescongelar.Text = "Descongelar";
            this.btnDescongelar.UseVisualStyleBackColor = true;
            // 
            // btnRefeicao
            // 
            this.btnRefeicao.Location = new System.Drawing.Point(40, 23);
            this.btnRefeicao.Name = "btnRefeicao";
            this.btnRefeicao.Size = new System.Drawing.Size(79, 23);
            this.btnRefeicao.TabIndex = 19;
            this.btnRefeicao.Text = "Refeição";
            this.btnRefeicao.UseVisualStyleBackColor = true;
            // 
            // btnPipoca
            // 
            this.btnPipoca.Location = new System.Drawing.Point(40, 52);
            this.btnPipoca.Name = "btnPipoca";
            this.btnPipoca.Size = new System.Drawing.Size(79, 23);
            this.btnPipoca.TabIndex = 20;
            this.btnPipoca.Text = "Pipoca";
            this.btnPipoca.UseVisualStyleBackColor = true;
            // 
            // pnlVisor
            // 
            this.pnlVisor.BackColor = System.Drawing.Color.Black;
            this.pnlVisor.Controls.Add(this.lblVisor);
            this.pnlVisor.Location = new System.Drawing.Point(81, 12);
            this.pnlVisor.Name = "pnlVisor";
            this.pnlVisor.Size = new System.Drawing.Size(250, 60);
            this.pnlVisor.TabIndex = 21;
            this.pnlVisor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVisor_Paint);
            // 
            // pnlTeclado
            // 
            this.pnlTeclado.Controls.Add(this.bt01);
            this.pnlTeclado.Controls.Add(this.bt02);
            this.pnlTeclado.Controls.Add(this.bt03);
            this.pnlTeclado.Controls.Add(this.bt04);
            this.pnlTeclado.Controls.Add(this.bt05);
            this.pnlTeclado.Controls.Add(this.bt00);
            this.pnlTeclado.Controls.Add(this.bt06);
            this.pnlTeclado.Controls.Add(this.bt09);
            this.pnlTeclado.Controls.Add(this.button2);
            this.pnlTeclado.Controls.Add(this.bt07);
            this.pnlTeclado.Controls.Add(this.bt08);
            this.pnlTeclado.Controls.Add(this.btnIniciarAquecimento);
            this.pnlTeclado.Location = new System.Drawing.Point(12, 132);
            this.pnlTeclado.Name = "pnlTeclado";
            this.pnlTeclado.Size = new System.Drawing.Size(200, 200);
            this.pnlTeclado.TabIndex = 22;
            // 
            // grpProgramas
            // 
            this.grpProgramas.Controls.Add(this.btnRefeicao);
            this.grpProgramas.Controls.Add(this.btnPipoca);
            this.grpProgramas.Controls.Add(this.btnDescongelar);
            this.grpProgramas.Location = new System.Drawing.Point(278, 125);
            this.grpProgramas.Name = "grpProgramas";
            this.grpProgramas.Size = new System.Drawing.Size(151, 207);
            this.grpProgramas.TabIndex = 23;
            this.grpProgramas.TabStop = false;
            this.grpProgramas.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(466, 520);
            this.Controls.Add(this.grpProgramas);
            this.Controls.Add(this.pnlTeclado);
            this.Controls.Add(this.pnlVisor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.txtTempo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlVisor.ResumeLayout(false);
            this.pnlVisor.PerformLayout();
            this.pnlTeclado.ResumeLayout(false);
            this.grpProgramas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button btnIniciarAquecimento;
        private System.Windows.Forms.Label lblVisor;
        private System.Windows.Forms.Button bt01;
        private System.Windows.Forms.Button bt02;
        private System.Windows.Forms.Button bt03;
        private System.Windows.Forms.Button bt04;
        private System.Windows.Forms.Button bt05;
        private System.Windows.Forms.Button bt06;
        private System.Windows.Forms.Button bt07;
        private System.Windows.Forms.Button bt08;
        private System.Windows.Forms.Button bt09;
        private System.Windows.Forms.Button bt00;
        private System.Windows.Forms.Button btnDescongelar;
        private System.Windows.Forms.Button btnRefeicao;
        private System.Windows.Forms.Button btnPipoca;
        private System.Windows.Forms.Panel pnlVisor;
        private System.Windows.Forms.Panel pnlTeclado;
        private System.Windows.Forms.GroupBox grpProgramas;
    }
}

