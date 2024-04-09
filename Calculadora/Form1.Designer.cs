namespace Calculadora
{
    partial class Form1
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
            txtResposta = new TextBox();
            panel1 = new Panel();
            btnVirgula = new Button();
            btnIgual = new Button();
            btnLimpar = new Button();
            btnTres = new Button();
            btnSeis = new Button();
            btnPonto = new Button();
            btnNove = new Button();
            btnDois = new Button();
            btnCinco = new Button();
            btnOito = new Button();
            btnZero = new Button();
            btnUm = new Button();
            btnQuatro = new Button();
            btnSete = new Button();
            btnDividir = new Button();
            btnMultiplicar = new Button();
            btnMenos = new Button();
            btnMais = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtResposta
            // 
            txtResposta.BackColor = SystemColors.ButtonHighlight;
            txtResposta.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResposta.Location = new Point(29, 26);
            txtResposta.Multiline = true;
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(250, 57);
            txtResposta.TabIndex = 0;
            txtResposta.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVirgula);
            panel1.Controls.Add(btnIgual);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(btnTres);
            panel1.Controls.Add(btnSeis);
            panel1.Controls.Add(btnPonto);
            panel1.Controls.Add(btnNove);
            panel1.Controls.Add(btnDois);
            panel1.Controls.Add(btnCinco);
            panel1.Controls.Add(btnOito);
            panel1.Controls.Add(btnZero);
            panel1.Controls.Add(btnUm);
            panel1.Controls.Add(btnQuatro);
            panel1.Controls.Add(btnSete);
            panel1.Controls.Add(btnDividir);
            panel1.Controls.Add(btnMultiplicar);
            panel1.Controls.Add(btnMenos);
            panel1.Controls.Add(btnMais);
            panel1.Location = new Point(29, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 298);
            panel1.TabIndex = 1;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(189, 119);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(56, 46);
            btnVirgula.TabIndex = 18;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.Lime;
            btnIgual.Location = new Point(189, 171);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(56, 98);
            btnIgual.TabIndex = 17;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Red;
            btnLimpar.Location = new Point(65, 223);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(118, 46);
            btnLimpar.TabIndex = 16;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(127, 171);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(56, 46);
            btnTres.TabIndex = 15;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(127, 119);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(56, 46);
            btnSeis.TabIndex = 14;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnPonto
            // 
            btnPonto.Location = new Point(189, 67);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(56, 46);
            btnPonto.TabIndex = 13;
            btnPonto.Text = ".";
            btnPonto.UseVisualStyleBackColor = true;
            btnPonto.Click += btnPonto_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(127, 67);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(56, 46);
            btnNove.TabIndex = 11;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(65, 171);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(56, 46);
            btnDois.TabIndex = 10;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(65, 119);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(56, 46);
            btnCinco.TabIndex = 9;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(65, 67);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(56, 46);
            btnOito.TabIndex = 8;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(3, 223);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(56, 46);
            btnZero.TabIndex = 7;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(3, 171);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(56, 46);
            btnUm.TabIndex = 6;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(3, 119);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(56, 46);
            btnQuatro.TabIndex = 5;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(3, 67);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(56, 46);
            btnSete.TabIndex = 4;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(189, 15);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(56, 46);
            btnDividir.TabIndex = 3;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(127, 15);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(56, 46);
            btnMultiplicar.TabIndex = 2;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnMenos
            // 
            btnMenos.Location = new Point(65, 15);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(56, 46);
            btnMenos.TabIndex = 1;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnMais
            // 
            btnMais.Location = new Point(3, 15);
            btnMais.Name = "btnMais";
            btnMais.Size = new Size(56, 46);
            btnMais.TabIndex = 0;
            btnMais.Text = "+";
            btnMais.UseVisualStyleBackColor = true;
            btnMais.Click += btnMais_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(292, 384);
            Controls.Add(panel1);
            Controls.Add(txtResposta);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResposta;
        private Panel panel1;
        private Button btnSete;
        private Button btnDividir;
        private Button btnMultiplicar;
        private Button btnMenos;
        private Button btnMais;
        private Button btnVirgula;
        private Button btnIgual;
        private Button btnLimpar;
        private Button btnTres;
        private Button btnSeis;
        private Button btnPonto;
        private Button btnNove;
        private Button btnDois;
        private Button btnCinco;
        private Button btnOito;
        private Button btnZero;
        private Button btnUm;
        private Button btnQuatro;
    }
}
