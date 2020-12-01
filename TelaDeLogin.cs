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
    public partial class TelaDeLogin : UserControl
    {
        public TelaDeLogin()
        {
            InitializeComponent();
        }

        //TESTAR CLASE MODAL NESTE PONTO PARA BLOQUEAR A TELA ATRAS
        private void BotaoLoginConectar_Click_1(object sender, EventArgs e)
        {
            if (BoxLogin.Text == "a" && BoxSenha.Text == "a")
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou Senha incorretos!");
            }
        }
    }
}
