using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa
{
    public partial class tela1 : Form
    {
        public tela1()
        {
            InitializeComponent();
        }

        private void txt_resul_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_resul.Text = "0";
            txt_v1.Text = "0";
            txt_v2.Text = "0";
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            txt_resul.Text = txt_v1.Text + " " + txt_v2.Text;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            txt_resul.Text = Convert.ToString(Convert.ToInt64(txt_v1.Text) + Convert.ToInt64(txt_v2.Text));
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            txt_resul.Text = Convert.ToString(Convert.ToInt64(txt_v1.Text) - Convert.ToInt64(txt_v2.Text));
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            txt_resul.Text = Convert.ToString(Convert.ToInt64(txt_v1.Text) * Convert.ToInt64(txt_v2.Text));
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (txt_v2.Text == "0")
            {

                txt_resul.Text = "INVALIDO!";
            }
            else
            {
                txt_resul.Text = Convert.ToString(Convert.ToInt64(txt_v1.Text) / Convert.ToInt64(txt_v2.Text));
            }
        }

        private void rdb_soma_CheckedChanged(object sender, EventArgs e)
        {
            txt_resul.Text = Convert.ToString(Convert.ToInt64(txt_v1.Text) + Convert.ToInt64(txt_v2.Text));
        }

        private void rdb_sub_CheckedChanged(object sender, EventArgs e)
        {
            txt_resul.Text = Convert.ToString(Convert.ToInt64(txt_v1.Text) - Convert.ToInt64(txt_v2.Text));
        }

        private void rdb_mult_CheckedChanged(object sender, EventArgs e)
        {
            txt_resul.Text = Convert.ToString(Convert.ToInt64(txt_v1.Text) * Convert.ToInt64(txt_v2.Text));
        }

        private void rdb_div_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_v2.Text == "0")
            {

                txt_resul.Text = "INVALIDO!";
            }
            else
            {
                txt_resul.Text = Convert.ToString(Convert.ToInt64(txt_v1.Text) / Convert.ToInt64(txt_v2.Text));
            }
        }

        private void rdb_opcao_CheckedChanged(object sender, EventArgs e)
        {
            grb_botao.Visible = false;
            grb_opcao.Visible = true;
        }

        private void rdb_botao_CheckedChanged(object sender, EventArgs e)
        {
            grb_botao.Visible = true;
            grb_opcao.Visible = false;
        }

        private void rdb_nenhum_CheckedChanged(object sender, EventArgs e)
        {
            grb_botao.Visible = false;
            grb_opcao.Visible = false;
        }
    }
}
