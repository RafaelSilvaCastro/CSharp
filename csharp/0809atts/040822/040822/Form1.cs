using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _040822
{
    public partial class jogo_da_velha : Form
    {
        public jogo_da_velha()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Jogada()
        {
        
            if(txtjogador.Text == "1") {
                txtdesenho.Text = "x";
                txtjogador.Text = "2";
                
            }

            else
            {
                txtdesenho.Text = "O";
                txtjogador.Text = "1";

            }
            txt_velha.Text = Convert.ToString(Convert.ToInt32(txt_velha.Text) + 1);
        
        
        
        }

        private void Bloquear()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;

        }
        private void Liberar()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            txtjogador.Text = "1";
            txt_velha.Text = "0";

        }

        private void Verificar() { 
        if (btn1.Text==btn2.Text && btn2.Text==btn3.Text && btn1.Text!= "") { // linha 1
                MessageBox.Show("Você venceu na linha 1!!!!!");
                Bloquear();           
            }else if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn6.Text!= "") // linha 2
            {
                MessageBox.Show("Você venceu na linha 2 !!!!!");
                Bloquear();
            }
            else if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn9.Text != "") // linha 3
            {
                MessageBox.Show("Você venceu na linha 3!!!!!");
                Bloquear();
            }
            else if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn7.Text!= "") // coluna 1
            {
                MessageBox.Show("Você venceu na coluna 1 !!!!!");
                Bloquear();
            }
            else if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn8.Text != "") // coluna 2
            {
                MessageBox.Show("Você venceu na coluna 2!!!!!");
                Bloquear();
            }
            else if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn9.Text != "") // coluna 3
            {
                MessageBox.Show("Você venceu na coluna 3!!!!!");
                Bloquear();
            }
            else if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn9.Text != "") // diagonal 1
            {
                MessageBox.Show("Você venceu na diagonal 1!!!!!");
                Bloquear();
            }
            else if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn7.Text != "") // diagonal 2
            {
                MessageBox.Show("Você venceu !!!!! na diagonal 2");
                Bloquear();
            }
            else if (txt_velha.Text == "9")
            {
                MessageBox.Show("Velha !!!!!");
            }
        }

        private void jogo_da_velha_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Jogada();
            btn1.Text = txtdesenho.Text;
            btn1.Enabled = false;
            Verificar();
         }

        private void btn2_Click(object sender, EventArgs e)
        {
            Jogada();
            btn2.Text = txtdesenho.Text;
            btn2.Enabled = false;
            Verificar();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Jogada();
            btn3.Text = txtdesenho.Text;
            btn3.Enabled = false;
            Verificar();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Jogada();
            btn4.Text = txtdesenho.Text;
            btn4.Enabled = false;
            Verificar();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Jogada();
            btn5.Text = txtdesenho.Text;
            btn5.Enabled = false;
            Verificar();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Jogada();
            btn6.Text = txtdesenho.Text;
            btn6.Enabled = false;
            Verificar();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Jogada();
            btn7.Text = txtdesenho.Text;
            btn7.Enabled = false;
            Verificar();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Jogada();
            btn8.Text = txtdesenho.Text;
            btn8.Enabled = false;
            Verificar();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Jogada();
            btn9.Text = txtdesenho.Text;
            btn9.Enabled = false;
            Verificar();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnnovojogo_Click(object sender, EventArgs e)
        {
            Liberar();
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
