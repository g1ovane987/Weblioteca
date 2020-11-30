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
    public partial class ManterClientes : UserControl
    {
        public ManterClientes()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HistoricoCliente historicoCliente1 = new HistoricoCliente();
            historicoCliente1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancelar a operação?", "Cancelar a operação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBoxNomeAutor.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro Gravado com Sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o cliente?", "Deseja excluir o cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBoxNomeAutor.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    pictureBox1.ImageLocation = openFileDialog.FileName;

                }
            }
        }
    }
}
