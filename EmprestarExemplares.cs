using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeDeFrontEnd1
{
    public partial class EmprestarExemplares : UserControl
    {
        public EmprestarExemplares()
        {
            InitializeComponent();
        }

        private void button3Limpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1Gravar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro Gravado com Sucesso!");
        }
    }
}
