
namespace tres_nomes
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_vescolhido = new System.Windows.Forms.ListBox();
            this.cmb_item = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.var_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "votar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha um dos três abaixo:";
            // 
            // lst_vescolhido
            // 
            this.lst_vescolhido.FormattingEnabled = true;
            this.lst_vescolhido.Location = new System.Drawing.Point(613, 73);
            this.lst_vescolhido.Name = "lst_vescolhido";
            this.lst_vescolhido.Size = new System.Drawing.Size(120, 95);
            this.lst_vescolhido.TabIndex = 2;
            // 
            // cmb_item
            // 
            this.cmb_item.FormattingEnabled = true;
            this.cmb_item.Items.AddRange(new object[] {
            "xbox",
            "sony",
            "nintendo"});
            this.cmb_item.Location = new System.Drawing.Point(111, 158);
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.Size = new System.Drawing.Size(121, 21);
            this.cmb_item.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Esse programa fará 10 pesquisas, e no final, mostrará uma votação\r\n\r\n";
            // 
            // var_num
            // 
            this.var_num.AutoSize = true;
            this.var_num.Location = new System.Drawing.Point(714, 45);
            this.var_num.Name = "var_num";
            this.var_num.Size = new System.Drawing.Size(19, 13);
            this.var_num.TabIndex = 5;
            this.var_num.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.var_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_item);
            this.Controls.Add(this.lst_vescolhido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_vescolhido;
        private System.Windows.Forms.ComboBox cmb_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label var_num;
    }
}

