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
    public partial class EspaceConnection : Form
    {
        public EspaceConnection()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((nomTbx.Text == "swiss") && (mdpTbx.Text == "18-jun-2003") 
                || (nomTbx.Text == "Villechalane") && (mdpTbx.Text == "11-dec-1992")
                || (nomTbx.Text == "Andre") && (mdpTbx.Text == "26-aug-1991")
                || (nomTbx.Text == "Bentot") && (mdpTbx.Text == "11-mar-1996"))
            {
                MessageBox.Show("Authentification Réussie");
                //Equivalent au code ci-dessous mais en ouvrant une autre page
                FMenuPrincipal fmenuprincipal = new FMenuPrincipal();
                fmenuprincipal.ShowDialog();        
            }
            else
            {
                MessageBox.Show("Nom ou Mot de passe incorrect");
            }
        }

    }
}
