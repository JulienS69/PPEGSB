using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Metier;

namespace PPEGSB
{
    public partial class FVisiteurs : Form
    {
        public FVisiteurs()
        {
            InitializeComponent();
        }

        private void FVisiteurs_Load(object sender, EventArgs e)
        {
            List<Visiteur> visiteurs = DAOVisiteurs.GetVisiteurs();
            foreach (Visiteur visiteur in visiteurs)
            {
                string[] row = { visiteur.Matricule, visiteur.Nom, visiteur.Prenom, visiteur.Adresse, visiteur.Cp, visiteur.Ville, visiteur.DateEmbauche };
                ListViewItem listViewItem = new ListViewItem(row);
                lvVisiteurs.Items.Add(listViewItem);
            }
        }
    }
}
