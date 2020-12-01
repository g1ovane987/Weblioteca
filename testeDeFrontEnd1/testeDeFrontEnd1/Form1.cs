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
    public partial class Form1 : Form
    {
        public Form1(){
            InitializeComponent();
            
            SidePanelForm1.Height = botaoHome.Height;
            SidePanelForm1.Top = botaoHome.Top;
            telaHome1.BringToFront();
            telaDeLogin1.BringToFront();
        }

        private void botaoHome_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = botaoHome.Height;
            SidePanelForm1.Top = botaoHome.Top;
            telaHome1.BringToFront();
        }

        private void BotaoCadastros_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = BotaoCadastros.Height;
            SidePanelForm1.Top = BotaoCadastros.Top;
            cadastros1.BringToFront();
        }

        private void BotaoEmprestimos_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = BotaoEmprestimos.Height;
            SidePanelForm1.Top = BotaoEmprestimos.Top;
            emprestimos1.BringToFront();
        }

        private void BotaoReservas_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = BotaoReservas.Height;
            SidePanelForm1.Top = BotaoReservas.Top;
            reservas1.BringToFront();
        }

        private void BotaoRelatorios_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = BotaoRelatorios.Height;
            SidePanelForm1.Top = BotaoRelatorios.Top;
            relatorios1.BringToFront();
        }

        private void SairSistema_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = SairSistema.Height;
            SidePanelForm1.Top = SairSistema.Top;

            if (MessageBox.Show("Finalizar programa?", "Finalizar o sistema?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }


    }
}
