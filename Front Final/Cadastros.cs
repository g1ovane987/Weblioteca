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
    public partial class Cadastros : UserControl
    {
        public Cadastros()
        {
            InitializeComponent();
            SidePanelCadastros.Height = ManterClientes.Height;
            SidePanelCadastros.Top = ManterClientes.Top;
            manterClientes1.BringToFront();
        }

        private void ManterClientes_Click(object sender, EventArgs e)
        {
            SidePanelCadastros.Height = ManterClientes.Height;
            SidePanelCadastros.Top = ManterClientes.Top;
            manterClientes1.BringToFront();
        }

        private void ManterLivros_Click(object sender, EventArgs e)
        {
            SidePanelCadastros.Height = ManterLivros.Height;
            SidePanelCadastros.Top = ManterLivros.Top;
            manterLivros1.BringToFront();
        }

        private void ManterAutores_Click(object sender, EventArgs e)
        {
            SidePanelCadastros.Height = ManterAutores.Height;
            SidePanelCadastros.Top = ManterAutores.Top;
            manterAutores1.BringToFront();
        }

        private void ManterEditoras_Click(object sender, EventArgs e)
        {
            SidePanelCadastros.Height = ManterEditoras.Height;
            SidePanelCadastros.Top = ManterEditoras.Top;
            manterEditoras1.BringToFront();
        }

        private void ManterFuncionarios_Click(object sender, EventArgs e)
        {
            SidePanelCadastros.Height = ManterFuncionarios.Height;
            SidePanelCadastros.Top = ManterFuncionarios.Top;
            manterFuncionarios1.BringToFront();
        }
    }
}
