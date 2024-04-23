using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            lst_valores.Items.Clear();
            if (Convert.ToInt32(txt_v2.Text) < Convert.ToInt32(txt_v1.Text))
            {
                var_troca_valor.Text = txt_v2.Text;
                txt_v2.Text = txt_v1.Text;
                txt_v1.Text = var_troca_valor.Text;
            }
                for (int i = Convert.ToInt32(txt_v1.Text); i <= Convert.ToInt32(txt_v2.Text); i++)
                {
                    lst_valores.Items.Add(i);
                }
        }
    }
}
