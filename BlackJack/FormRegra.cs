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
    public partial class FormRegra : Form
    {
        public FormRegra()
        {
            InitializeComponent();
        }

        private void FormRegra_Load(object sender, EventArgs e)
        {

        }

        private void btnRegrasVoltar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
