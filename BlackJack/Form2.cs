using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class form_apresentacao : Form
    {
        public form_apresentacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            Form jogo = new Form_jogo();
            jogo.Show();
            this.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegra_Click(object sender, EventArgs e)
        {
            Form Regra = new FormRegra();
            Regra.Show();
            this.Visible = true;
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            Form Sobre = new FormSobre();
            Sobre.Show();
            this.Visible = true;
        }
    }
}
