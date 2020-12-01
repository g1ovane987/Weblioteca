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
    public partial class Reservas : UserControl
    {
        public Reservas()
        {
            InitializeComponent();
            SidePanelForm1.Height = ReservarExemplares.Height;
            SidePanelForm1.Top = ReservarExemplares.Top;
            reservarExemplar1.BringToFront();
        }

        private void ReservarExemplares_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = ReservarExemplares.Height;
            SidePanelForm1.Top = ReservarExemplares.Top;
            reservarExemplar1.BringToFront();
        }

        private void CancelarReserva_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = CancelarReserva.Height;
            SidePanelForm1.Top = CancelarReserva.Top;
            cancelarReserva1.BringToFront();
        }

        private void EmprestimoReserva_Click(object sender, EventArgs e)
        {
            SidePanelForm1.Height = EmprestimoReserva.Height;
            SidePanelForm1.Top = EmprestimoReserva.Top;
            emprestimoReserva1.BringToFront();
        }
    }
}
