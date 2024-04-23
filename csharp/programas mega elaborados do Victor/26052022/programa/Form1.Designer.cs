
namespace programa
{
    partial class tela1
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
            this.lbl_v1 = new System.Windows.Forms.Label();
            this.txt_v1 = new System.Windows.Forms.TextBox();
            this.lbl_resul = new System.Windows.Forms.Label();
            this.txt_resul = new System.Windows.Forms.TextBox();
            this.txt_v2 = new System.Windows.Forms.TextBox();
            this.lbl_v2 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.grb_botao = new System.Windows.Forms.GroupBox();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_soma = new System.Windows.Forms.Button();
            this.grb_opcao = new System.Windows.Forms.GroupBox();
            this.rdb_div = new System.Windows.Forms.RadioButton();
            this.rdb_mult = new System.Windows.Forms.RadioButton();
            this.rdb_sub = new System.Windows.Forms.RadioButton();
            this.rdb_soma = new System.Windows.Forms.RadioButton();
            this.grb_escolha = new System.Windows.Forms.GroupBox();
            this.rdb_opcao = new System.Windows.Forms.RadioButton();
            this.rdb_botao = new System.Windows.Forms.RadioButton();
            this.rdb_nenhum = new System.Windows.Forms.RadioButton();
            this.grb_botao.SuspendLayout();
            this.grb_opcao.SuspendLayout();
            this.grb_escolha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_v1
            // 
            this.lbl_v1.AutoSize = true;
            this.lbl_v1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_v1.Location = new System.Drawing.Point(276, 106);
            this.lbl_v1.Name = "lbl_v1";
            this.lbl_v1.Size = new System.Drawing.Size(220, 24);
            this.lbl_v1.TabIndex = 0;
            this.lbl_v1.Text = "INSIRA O 1° VALOR:";
            // 
            // txt_v1
            // 
            this.txt_v1.Location = new System.Drawing.Point(523, 106);
            this.txt_v1.Name = "txt_v1";
            this.txt_v1.Size = new System.Drawing.Size(100, 20);
            this.txt_v1.TabIndex = 1;
            this.txt_v1.Text = "0";
            // 
            // lbl_resul
            // 
            this.lbl_resul.AutoSize = true;
            this.lbl_resul.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resul.Location = new System.Drawing.Point(276, 255);
            this.lbl_resul.Name = "lbl_resul";
            this.lbl_resul.Size = new System.Drawing.Size(150, 24);
            this.lbl_resul.TabIndex = 3;
            this.lbl_resul.Text = "RESULTADO:";
            // 
            // txt_resul
            // 
            this.txt_resul.Enabled = false;
            this.txt_resul.Location = new System.Drawing.Point(523, 255);
            this.txt_resul.Name = "txt_resul";
            this.txt_resul.Size = new System.Drawing.Size(100, 20);
            this.txt_resul.TabIndex = 4;
            this.txt_resul.Text = "0";
            this.txt_resul.TextChanged += new System.EventHandler(this.txt_resul_TextChanged);
            // 
            // txt_v2
            // 
            this.txt_v2.Location = new System.Drawing.Point(523, 181);
            this.txt_v2.Name = "txt_v2";
            this.txt_v2.Size = new System.Drawing.Size(100, 20);
            this.txt_v2.TabIndex = 5;
            this.txt_v2.Text = "0";
            // 
            // lbl_v2
            // 
            this.lbl_v2.AutoSize = true;
            this.lbl_v2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_v2.Location = new System.Drawing.Point(276, 181);
            this.lbl_v2.Name = "lbl_v2";
            this.lbl_v2.Size = new System.Drawing.Size(220, 24);
            this.lbl_v2.TabIndex = 6;
            this.lbl_v2.Text = "INSIRA O 2° VALOR:";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_sair.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(784, 514);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(131, 40);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(273, 11);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(357, 38);
            this.lbl_titulo.TabIndex = 9;
            this.lbl_titulo.Text = "~CALCULADORA~";
            this.lbl_titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_limpar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(492, 430);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(131, 40);
            this.btn_limpar.TabIndex = 10;
            this.btn_limpar.Text = "limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_verificar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verificar.Location = new System.Drawing.Point(295, 430);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(131, 40);
            this.btn_verificar.TabIndex = 11;
            this.btn_verificar.Text = "verificar";
            this.btn_verificar.UseVisualStyleBackColor = false;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // grb_botao
            // 
            this.grb_botao.BackColor = System.Drawing.Color.DodgerBlue;
            this.grb_botao.Controls.Add(this.btn_div);
            this.grb_botao.Controls.Add(this.btn_mult);
            this.grb_botao.Controls.Add(this.btn_sub);
            this.grb_botao.Controls.Add(this.btn_soma);
            this.grb_botao.Location = new System.Drawing.Point(716, 109);
            this.grb_botao.Name = "grb_botao";
            this.grb_botao.Size = new System.Drawing.Size(199, 361);
            this.grb_botao.TabIndex = 12;
            this.grb_botao.TabStop = false;
            this.grb_botao.Text = "botões";
            this.grb_botao.Visible = false;
            this.grb_botao.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_div.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_div.Location = new System.Drawing.Point(39, 183);
            this.btn_div.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(128, 32);
            this.btn_div.TabIndex = 3;
            this.btn_div.Text = "dividir";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_mult.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mult.Location = new System.Drawing.Point(39, 127);
            this.btn_mult.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(128, 32);
            this.btn_mult.TabIndex = 2;
            this.btn_mult.Text = "multiplicar";
            this.btn_mult.UseVisualStyleBackColor = false;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_sub.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.Location = new System.Drawing.Point(39, 71);
            this.btn_sub.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(128, 32);
            this.btn_sub.TabIndex = 1;
            this.btn_sub.Text = "subtrair";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_soma
            // 
            this.btn_soma.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_soma.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_soma.Location = new System.Drawing.Point(39, 15);
            this.btn_soma.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(128, 32);
            this.btn_soma.TabIndex = 0;
            this.btn_soma.Text = "soma";
            this.btn_soma.UseVisualStyleBackColor = false;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // grb_opcao
            // 
            this.grb_opcao.BackColor = System.Drawing.Color.DodgerBlue;
            this.grb_opcao.Controls.Add(this.rdb_div);
            this.grb_opcao.Controls.Add(this.rdb_mult);
            this.grb_opcao.Controls.Add(this.rdb_sub);
            this.grb_opcao.Controls.Add(this.rdb_soma);
            this.grb_opcao.Location = new System.Drawing.Point(12, 109);
            this.grb_opcao.Name = "grb_opcao";
            this.grb_opcao.Size = new System.Drawing.Size(199, 361);
            this.grb_opcao.TabIndex = 13;
            this.grb_opcao.TabStop = false;
            this.grb_opcao.Text = "opcões";
            this.grb_opcao.Visible = false;
            // 
            // rdb_div
            // 
            this.rdb_div.AutoSize = true;
            this.rdb_div.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_div.Location = new System.Drawing.Point(6, 184);
            this.rdb_div.Margin = new System.Windows.Forms.Padding(3, 32, 3, 32);
            this.rdb_div.Name = "rdb_div";
            this.rdb_div.Size = new System.Drawing.Size(79, 25);
            this.rdb_div.TabIndex = 3;
            this.rdb_div.TabStop = true;
            this.rdb_div.Text = "dividir";
            this.rdb_div.UseVisualStyleBackColor = true;
            this.rdb_div.CheckedChanged += new System.EventHandler(this.rdb_div_CheckedChanged);
            // 
            // rdb_mult
            // 
            this.rdb_mult.AutoSize = true;
            this.rdb_mult.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_mult.Location = new System.Drawing.Point(6, 144);
            this.rdb_mult.Margin = new System.Windows.Forms.Padding(3, 32, 3, 32);
            this.rdb_mult.Name = "rdb_mult";
            this.rdb_mult.Size = new System.Drawing.Size(115, 25);
            this.rdb_mult.TabIndex = 2;
            this.rdb_mult.TabStop = true;
            this.rdb_mult.Text = "multiplicar";
            this.rdb_mult.UseVisualStyleBackColor = true;
            this.rdb_mult.CheckedChanged += new System.EventHandler(this.rdb_mult_CheckedChanged);
            // 
            // rdb_sub
            // 
            this.rdb_sub.AutoSize = true;
            this.rdb_sub.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_sub.Location = new System.Drawing.Point(6, 95);
            this.rdb_sub.Margin = new System.Windows.Forms.Padding(3, 32, 3, 32);
            this.rdb_sub.Name = "rdb_sub";
            this.rdb_sub.Size = new System.Drawing.Size(89, 25);
            this.rdb_sub.TabIndex = 1;
            this.rdb_sub.TabStop = true;
            this.rdb_sub.Text = "subtrair";
            this.rdb_sub.UseVisualStyleBackColor = true;
            this.rdb_sub.CheckedChanged += new System.EventHandler(this.rdb_sub_CheckedChanged);
            // 
            // rdb_soma
            // 
            this.rdb_soma.AutoSize = true;
            this.rdb_soma.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_soma.Location = new System.Drawing.Point(6, 55);
            this.rdb_soma.Margin = new System.Windows.Forms.Padding(3, 32, 3, 32);
            this.rdb_soma.Name = "rdb_soma";
            this.rdb_soma.Size = new System.Drawing.Size(74, 25);
            this.rdb_soma.TabIndex = 0;
            this.rdb_soma.TabStop = true;
            this.rdb_soma.Text = "somar";
            this.rdb_soma.UseVisualStyleBackColor = true;
            this.rdb_soma.CheckedChanged += new System.EventHandler(this.rdb_soma_CheckedChanged);
            // 
            // grb_escolha
            // 
            this.grb_escolha.Controls.Add(this.rdb_nenhum);
            this.grb_escolha.Controls.Add(this.rdb_botao);
            this.grb_escolha.Controls.Add(this.rdb_opcao);
            this.grb_escolha.Location = new System.Drawing.Point(211, 53);
            this.grb_escolha.Name = "grb_escolha";
            this.grb_escolha.Size = new System.Drawing.Size(505, 34);
            this.grb_escolha.TabIndex = 14;
            this.grb_escolha.TabStop = false;
            this.grb_escolha.Text = "Modo de Operação";
            // 
            // rdb_opcao
            // 
            this.rdb_opcao.AutoSize = true;
            this.rdb_opcao.Location = new System.Drawing.Point(6, 11);
            this.rdb_opcao.Name = "rdb_opcao";
            this.rdb_opcao.Size = new System.Drawing.Size(60, 17);
            this.rdb_opcao.TabIndex = 0;
            this.rdb_opcao.TabStop = true;
            this.rdb_opcao.Text = "opções";
            this.rdb_opcao.UseVisualStyleBackColor = true;
            this.rdb_opcao.CheckedChanged += new System.EventHandler(this.rdb_opcao_CheckedChanged);
            // 
            // rdb_botao
            // 
            this.rdb_botao.AutoSize = true;
            this.rdb_botao.Location = new System.Drawing.Point(228, 11);
            this.rdb_botao.Name = "rdb_botao";
            this.rdb_botao.Size = new System.Drawing.Size(57, 17);
            this.rdb_botao.TabIndex = 1;
            this.rdb_botao.TabStop = true;
            this.rdb_botao.Text = "botões";
            this.rdb_botao.UseVisualStyleBackColor = true;
            this.rdb_botao.CheckedChanged += new System.EventHandler(this.rdb_botao_CheckedChanged);
            // 
            // rdb_nenhum
            // 
            this.rdb_nenhum.AutoSize = true;
            this.rdb_nenhum.Location = new System.Drawing.Point(436, 11);
            this.rdb_nenhum.Name = "rdb_nenhum";
            this.rdb_nenhum.Size = new System.Drawing.Size(63, 17);
            this.rdb_nenhum.TabIndex = 2;
            this.rdb_nenhum.TabStop = true;
            this.rdb_nenhum.Text = "nenhum";
            this.rdb_nenhum.UseVisualStyleBackColor = true;
            this.rdb_nenhum.CheckedChanged += new System.EventHandler(this.rdb_nenhum_CheckedChanged);
            // 
            // tela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(927, 561);
            this.Controls.Add(this.grb_escolha);
            this.Controls.Add(this.grb_opcao);
            this.Controls.Add(this.grb_botao);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_v2);
            this.Controls.Add(this.txt_v2);
            this.Controls.Add(this.txt_resul);
            this.Controls.Add(this.lbl_resul);
            this.Controls.Add(this.txt_v1);
            this.Controls.Add(this.lbl_v1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(943, 600);
            this.MinimumSize = new System.Drawing.Size(943, 600);
            this.Name = "tela1";
            this.Text = "calculadora";
            this.grb_botao.ResumeLayout(false);
            this.grb_opcao.ResumeLayout(false);
            this.grb_opcao.PerformLayout();
            this.grb_escolha.ResumeLayout(false);
            this.grb_escolha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_v1;
        private System.Windows.Forms.TextBox txt_v1;
        private System.Windows.Forms.Label lbl_resul;
        private System.Windows.Forms.TextBox txt_resul;
        private System.Windows.Forms.TextBox txt_v2;
        private System.Windows.Forms.Label lbl_v2;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.GroupBox grb_botao;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.GroupBox grb_opcao;
        private System.Windows.Forms.RadioButton rdb_div;
        private System.Windows.Forms.RadioButton rdb_mult;
        private System.Windows.Forms.RadioButton rdb_sub;
        private System.Windows.Forms.RadioButton rdb_soma;
        private System.Windows.Forms.GroupBox grb_escolha;
        private System.Windows.Forms.RadioButton rdb_nenhum;
        private System.Windows.Forms.RadioButton rdb_botao;
        private System.Windows.Forms.RadioButton rdb_opcao;
    }
}

