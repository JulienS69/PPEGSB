using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;
using DAO;

namespace PPEGSB
{
    public partial class Medicaments : Form
    {
        public Medicaments()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //On récupère la liste des clients (objets métiers)
            List<Medicament> medicaments = DAOMedicament.GetMedicaments();
            //On teste si cette liste n'est pas null
            //Si la liste est null, cela signifie que les données n'ont pu être chargées.
            if (medicaments != null)
            {
                //On parcourt cette liste afin de placer chaque instance dans une ligne de la ListView
                foreach (Medicament medicament  in medicaments)
                {
                    //On crée un tableau de chaine de caractères : chaque cellule contient un attribut chaine de caractères du client
                    string[] row = { medicament.DepotLegal, medicament.NomCommercial, medicament.Composition, medicament.Effets, medicament.ContreIndications, medicament.PrixEchantillon.ToString() };
                    //On crée la ligne
                    ListViewItem listViewItem = new ListViewItem(row);
                    //On l'ajoute dans la listview
                    lVMedicaments.Items.Add(listViewItem);
                }
            }

        }
    }
}
