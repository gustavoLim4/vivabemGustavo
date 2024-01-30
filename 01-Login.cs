using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vivabem_Gustavo
{
    public partial class fmrLogin : Form
    {
        int mostra = 0;
        public fmrLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja Encerrar ?", "ENCERRAR", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pctFechar_MouseEnter(object sender, EventArgs e)
        {
            //quando o mouse passa por cima dele 
            pctFechar.Size = new Size(44, 44);
            pctFechar.Location = new Point(446, 10);
        }

        private void pctFechar_MouseLeave(object sender, EventArgs e)
        {
            pctFechar.Size = new Size(40, 40);
            pctFechar.Location = new Point(448, 12);

        }

        private void pctMostrar_Click(object sender, EventArgs e)
        {
            if ( mostra == 0 )
            {
                txtSenha.PasswordChar = '\0';
                pctMostrar.Image = Properties.Resources.esconder;
                mostra = 1;
            }
            else
            {
                txtSenha.PasswordChar = '*';
                pctMostrar.Image = Properties.Resources.mostrar;
                mostra = 0;
                 
            }
        }
    }
}
