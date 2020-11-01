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
            this.Close();
            EspaceConnection Rapport_visite = new EspaceConnection();
            Rapport_visite.ShowDialog();
        }

        private void aProposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            APropos apropos = new APropos();
            apropos.ShowDialog();
        }

        private void FMenuPrincipal_Load(object sender, EventArgs e)
        {
            EspaceConnection.ActiveForm.Hide();
        }

        private void rapportVisiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRapportsDeVisite rapportvisite = new FRapportsDeVisite();
            rapportvisite.ShowDialog();
        }

        private void praticienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPraticiens praticiens = new FPraticiens();
            praticiens.ShowDialog();
        }

        private void visiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FVisiteurs visiteurs = new FVisiteurs();
            visiteurs.ShowDialog();
        }
    }
}
