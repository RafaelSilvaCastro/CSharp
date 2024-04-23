using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tela_usuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Limpar_campo()
        {
            txt_login.Text = "";
            txt_senha.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar_campo();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            if ((txt_login.Text == lbl_login.Text) && (txt_senha.Text == lbl_senha.Text))
            {
                MessageBox.Show("usuario valido");
                Limpar_campo();
                tela2 novaform = new tela2();
                novaform.Show();
            }
            else
            {
                if((txt_login.Text == "amogus") && (txt_senha.Text == "sus"))
                {
                    pcb_sus.Visible = true;
                }
                else
                {
                    MessageBox.Show("Login ou senha invalidas");
                    Limpar_campo();
                }
                
            }
        }
    }
}
