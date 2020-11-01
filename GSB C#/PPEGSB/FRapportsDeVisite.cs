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
    public partial class FRapportsDeVisite : Form
    {
        List<RapportDeVisite> rapportsRows = new List<RapportDeVisite>();
        List<Praticien> praticiens = DAOPraticiens.GetPraticien();
        int index = 0;
        Boolean nouveau = false;
        public FRapportsDeVisite()
        {
            InitializeComponent();
        }

        private void FRapportsDeVisite_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'ppegsbDataSet.presenter'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.presenterTableAdapter.Fill(this.ppegsbDataSet.presenter);
            //On récupère la liste des rapports de visite (objets métiers)
            List<RapportDeVisite> rapports = DAORapportVisite.GetRapports();
            //On teste si cette liste n'est pas null
            //Si la liste est null, cela signifie que les données n'ont pu être chargées.



            if (rapports != null)
            {
                //On parcourt cette liste afin de placer chaque instance dans une ligne de la ListView
               
                foreach (RapportDeVisite rapport in rapports)
                {
                    //On crée un tableau de chaine de caractères : chaque cellule contient un attribut chaine de caractères du client
                    RapportDeVisite unRapport = new RapportDeVisite(rapport.Numéro, rapport.Date, rapport.Bilan, rapport.Motif, rapport.NuméroPraticien, rapport.MatriculeVisiteur);
                    rapportsRows.Add(unRapport);

                }

            }
            RapportDeVisite actualRapport = rapportsRows[0];
            tbxNumRap.Text = actualRapport.Numéro;
            char[] separateurs = new char[] { '/', ':', ' ', '-' };
            List<string> eltDate = new List<string>(actualRapport.Date.Split(separateurs));
            DateTime newDate = new DateTime(Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[2]), Convert.ToInt32(eltDate[3]), Convert.ToInt32(eltDate[4]), Convert.ToInt32(eltDate[5]));
            string sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
            tbxDateRapport.Text = sqlFormattedDate;
            tbxMotif.Text = actualRapport.Motif;
            tbxBilan.Text = actualRapport.Bilan;
            Precedent.Enabled = false;

            cbxPraticien.Items.Clear();
            if (praticiens != null)
            {
                foreach (Praticien pratic in praticiens)
                {

                    string nomPrenom = pratic.Nom + " " + pratic.Prenom;

                    cbxPraticien.Items.Add(nomPrenom); 
                }
                cbxPraticien.SelectedIndex = actualRapport.NuméroPraticien - 1;
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.presenterTableAdapter.FillBy(this.ppegsbDataSet.presenter);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            if (index < rapportsRows.Count - 1)
            {
                index += 1;
                if (index == rapportsRows.Count - 1)
                {
                    Suivant.Enabled = false;
                }
                RapportDeVisite actualRapport = rapportsRows[index];
                tbxNumRap.Text = actualRapport.Numéro;
                tbxDateRapport.Text = actualRapport.Date.Substring(0, 10);
                tbxMotif.Text = actualRapport.Motif;
                tbxBilan.Text = actualRapport.Bilan;
                cbxPraticien.SelectedIndex = actualRapport.NuméroPraticien - 1;
                Precedent.Enabled = true;
                char[] separateurs = new char[] { '/', ':', ' ', '-' };;
                List<string> eltDate = new List<string>(actualRapport.Date.Split(separateurs));
                DateTime newDate = new DateTime(Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[2]), Convert.ToInt32(eltDate[3]), Convert.ToInt32(eltDate[4]), Convert.ToInt32(eltDate[5]));
                string sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
                tbxDateRapport.Text = sqlFormattedDate;
            }
        }

        private void Precedent_Click(object sender, EventArgs e)
        {
            Suivant.Enabled = true;
            if (index > 0)
            {
                index -= 1;
                if (index == 0)
                {
                    Precedent.Enabled = false;
                }
                RapportDeVisite actualRapport = rapportsRows[index];
                tbxNumRap.Text = actualRapport.Numéro;
                tbxDateRapport.Text = actualRapport.Date.Substring(0, 11);
                tbxMotif.Text = actualRapport.Motif;
                tbxBilan.Text = actualRapport.Bilan;
                cbxPraticien.SelectedIndex = actualRapport.NuméroPraticien - 1;
                char[] separateurs = new char[] { '/', ':', ' ', '-' };
                List<string> eltDate = new List<string>(actualRapport.Date.Split(separateurs));
                DateTime newDate = new DateTime(Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[2]), Convert.ToInt32(eltDate[3]), Convert.ToInt32(eltDate[4]), Convert.ToInt32(eltDate[5]));
                string sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
                tbxDateRapport.Text = sqlFormattedDate;
            }
            if (nouveau)
            {
                index = rapportsRows.Count - 1;
                tbxNumRap.Enabled = false;
                this.nouveau = false;
            }
        }


        private void cbxPraticien_TextChanged(object sender, EventArgs e)
        {
            // chercher si praticien existe
            

            string[] NomPrenom = cbxPraticien.Text.Split(' ');
            
            Praticien praticien;

            try
            {
                praticien = DAOPraticiens.GetPraticienParNomPrenom(NomPrenom[0], NomPrenom[1]);
            }
            catch(System.IndexOutOfRangeException)
            {
                MessageBox.Show("Format Incorrect");
                praticien = null;
            }
            
            if ((cbxPraticien.Text == "") || (praticien == null))
            {
                details.Enabled = false;
            }
            else
            {
                details.Enabled = true;
            }
            
        }

        private void details_Click(object sender, EventArgs e)
        {
            Praticien PraticienSelectionne;

            int indiceSelectionne = cbxPraticien.SelectedIndex;

            Praticien praticienSelectionne = praticiens[indiceSelectionne];

            FPraticien praticienSelect = new FPraticien(praticienSelectionne);
            praticienSelect.ShowDialog();
        }

        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            if (nouveau)
            {
                RapportDeVisite nouveauRapport = new RapportDeVisite();
                nouveauRapport.Numéro = tbxNumRap.Text;
                char[] separateurs = new char[] { '/', ':', ' ', '-' };
                string sqlFormattedDate = "1970-01-01";
                List<string> eltDate = new List<string>(tbxDateRapport.Text.Split(separateurs));
                if (eltDate.Count == 3)
                {
                    DateTime newDate = new DateTime(Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[2]));
                    sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else if (eltDate.Count == 6)
                {
                    DateTime newDate = new DateTime(Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[2]), Convert.ToInt32(eltDate[3]), Convert.ToInt32(eltDate[4]), Convert.ToInt32(eltDate[5]));
                    sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                nouveauRapport.Date = sqlFormattedDate;
                nouveauRapport.Bilan = tbxBilan.Text;
                nouveauRapport.Motif = tbxMotif.Text;
                nouveauRapport.NuméroPraticien = cbxPraticien.SelectedIndex + 1;
                if (DAORapportVisite.CreateRapport(nouveauRapport))
                {
                    rapportsRows.Add(nouveauRapport);
                };

            }
            else 
            { 
                RapportDeVisite rapportModifie = new RapportDeVisite();
                char[] separateurs = new char[] { '/', ':', ' ', '-' };
                string sqlFormattedDate = "1970-01-01";
                List<string> eltDate = new List<string>(tbxDateRapport.Text.Split(separateurs));
                if (eltDate.Count == 3)
                {
                    DateTime newDate = new DateTime(Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[2]));
                    sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else if (eltDate.Count == 6)
                {
                    DateTime newDate = new DateTime(Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[2]), Convert.ToInt32(eltDate[3]), Convert.ToInt32(eltDate[4]), Convert.ToInt32(eltDate[5]));
                    sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                rapportModifie.Numéro = tbxNumRap.Text;
                rapportModifie.Date = sqlFormattedDate;
                rapportModifie.Bilan = tbxBilan.Text;
                rapportModifie.Motif = tbxMotif.Text;
                rapportModifie.NuméroPraticien = cbxPraticien.SelectedIndex + 1;
                DAORapportVisite.UpdateRapport(rapportModifie);
                this.rapportsRows[index] = rapportModifie;
            }
        }

        private void btNouveau_Click(object sender, EventArgs e)
        {
            index = rapportsRows.Count;
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            tbxDateRapport.Text = sqlFormattedDate;
            tbxNumRap.Text = "";
            tbxNumRap.Enabled = true;
            tbxMotif.Text = "";
            tbxBilan.Text = "";
            cbxPraticien.SelectedIndex = 0;
            this.nouveau = true;
        }
    }
}
