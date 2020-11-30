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
    public partial class Relatorios : UserControl
    {
        public Relatorios()
        {
            InitializeComponent();
            SidePanelForm1.Height = RelatorioEmprestimosCliente.Height;
            SidePanelForm1.Top = RelatorioEmprestimosCliente.Top;
        }

        private void RelatorioEmprestimosCliente_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = RelatorioEmprestimosCliente.Height;
            SidePanelForm1.Top = RelatorioEmprestimosCliente.Top;
        }

        private void RelatorioEmprestimosDevolvidos_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = RelatorioEmprestimosDevolvidos.Height;
            SidePanelForm1.Top = RelatorioEmprestimosDevolvidos.Top;
        }

        private void RelatorioRentabilidadeExemplares_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = RelatorioRentabilidadeExemplares.Height;
            SidePanelForm1.Top = RelatorioRentabilidadeExemplares.Top;
        }
    }
}
