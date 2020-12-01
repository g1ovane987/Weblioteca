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
    public partial class Emprestimos : UserControl
    {
        public Emprestimos()
        {
            InitializeComponent();
            SidePanelForm1.Height = EmprestarExemplares.Height;
            SidePanelForm1.Top = EmprestarExemplares.Top;
            emprestarExemplares1.BringToFront();

        }

        private void EmprestarExemplares_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = EmprestarExemplares.Height;
            SidePanelForm1.Top = EmprestarExemplares.Top;
            emprestarExemplares1.BringToFront();
        }

        private void DevolucaoExemplares_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = DevolucaoExemplares.Height;
            SidePanelForm1.Top = DevolucaoExemplares.Top;
            devolucaoDeExemplares1.BringToFront();
        }

        private void FaturarEmprestimo_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = FaturarEmprestimo.Height;
            SidePanelForm1.Top = FaturarEmprestimo.Top;
            faturarEmprestimo1.BringToFront();
        }

        private void ProlongarEmprestimo_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = ProlongarEmprestimo.Height;
            SidePanelForm1.Top = ProlongarEmprestimo.Top;
            prolongarEmprestimo1.BringToFront();
        }

        private void button1AbonarMulta_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = button1AbonarMulta.Height;
            SidePanelForm1.Top = button1AbonarMulta.Top;
            abonarMulta1.BringToFront();
        }
    }
}
