
namespace atividade
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
            this.txt_v1 = new System.Windows.Forms.TextBox();
            this.txt_v2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_valores = new System.Windows.Forms.ListBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.var_troca_valor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_v1
            // 
            this.txt_v1.Location = new System.Drawing.Point(126, 82);
            this.txt_v1.Name = "txt_v1";
            this.txt_v1.Size = new System.Drawing.Size(100, 20);
            this.txt_v1.TabIndex = 0;
            this.txt_v1.Text = "0";
            // 
            // txt_v2
            // 
            this.txt_v2.Location = new System.Drawing.Point(126, 204);
            this.txt_v2.Name = "txt_v2";
            this.txt_v2.Size = new System.Drawing.Size(100, 20);
            this.txt_v2.TabIndex = 1;
            this.txt_v2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "valor inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "valor final";
            // 
            // lst_valores
            // 
            this.lst_valores.FormattingEnabled = true;
            this.lst_valores.Location = new System.Drawing.Point(321, 31);
            this.lst_valores.Name = "lst_valores";
            this.lst_valores.Size = new System.Drawing.Size(427, 394);
            this.lst_valores.TabIndex = 4;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(126, 323);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.Text = "calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // var_troca_valor
            // 
            this.var_troca_valor.AutoSize = true;
            this.var_troca_valor.Location = new System.Drawing.Point(689, 15);
            this.var_troca_valor.Name = "var_troca_valor";
            this.var_troca_valor.Size = new System.Drawing.Size(13, 13);
            this.var_troca_valor.TabIndex = 6;
            this.var_troca_valor.Text = "0";
            this.var_troca_valor.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.var_troca_valor);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lst_valores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_v2);
            this.Controls.Add(this.txt_v1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_v1;
        private System.Windows.Forms.TextBox txt_v2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_valores;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label var_troca_valor;
    }
}

