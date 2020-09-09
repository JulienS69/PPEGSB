using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPEGSB
{
    public partial class FMenuPrincipal : Form
    {
        public FMenuPrincipal()
        {
            InitializeComponent();
        }

        private void médicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicaments medicaments = new Medicaments();
            medicaments.ShowDialog();
        }

        private void quitterLapplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE Rapport_visite = new RAPPORT_VISITE();
            Rapport_visite.ShowDialog();
        }

        private void aProposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            APropos apropos = new APropos();
            apropos.ShowDialog();
        }
    }
}
