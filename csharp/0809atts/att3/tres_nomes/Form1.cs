using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tres_nomes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(var_num.Text) <= 0) && (cmb_item.SelectedItem != "")
            {
                lst_vescolhido.Items.Add(cmb_item.SelectedItem);
                var_num.Text = Convert.ToString(Convert.ToInt32(var_num.Text) - 1);
            }
            else
            {

                button1.Enabled = false;
            }
        }
    }
}
