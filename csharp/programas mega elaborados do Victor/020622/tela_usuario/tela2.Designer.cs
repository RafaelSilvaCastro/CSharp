﻿
namespace tela_usuario
{
    partial class tela2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lst_teste = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "roberto carlos entrou no servidor!";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(353, 392);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "Deslogar";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lst_teste
            // 
            this.lst_teste.FormattingEnabled = true;
            this.lst_teste.Items.AddRange(new object[] {
            "comprar carro",
            "vender iate",
            "alugar hotel",
            "vender animais raros",
            "encomendar pastel"});
            this.lst_teste.Location = new System.Drawing.Point(12, 12);
            this.lst_teste.Name = "lst_teste";
            this.lst_teste.Size = new System.Drawing.Size(120, 95);
            this.lst_teste.TabIndex = 2;
            // 
            // tela2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_teste);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label1);
            this.Name = "tela2";
            this.Text = "tela2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ListBox lst_teste;
    }
}