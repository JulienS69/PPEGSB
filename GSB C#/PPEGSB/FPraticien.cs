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
	public partial class FPraticien : Form
	{
		Praticien praticien;
		public FPraticien()
		{
			InitializeComponent();
		}

		public FPraticien(Praticien praticien) : this()
		{
			this.praticien = praticien;
			labTitre.Text = praticien.Nom + " " + praticien.Prenom;
		}

		private void FPraticien_Load(object sender, EventArgs e)
		{
			TypePraticien typePraticien = DAOTypePraticien.GetPraticien(praticien.CodeTypePraticien);
			string[] row = { praticien.Num.ToString(), praticien.Nom, praticien.Prenom, praticien.Adresse, praticien.Cp, praticien.Ville, praticien.CoefNotoriete.ToString(), praticien.CodeTypePraticien, typePraticien.Libelle, typePraticien.Lieu };
			// ListViewItem listViewItem = new ListViewItem(row);
			//lvPraticien.Items.Add(listViewItem);

			List<string> nomsChamps = new List<string> { "Numéro", "Nom", "Prénom", "Adresse", "Code Postal", "Ville", "Coefficient de notoriété", "Code du type de praticien", "Libellé type praticien", "Lieu de travail type praticien" };
			int i = 0;
			foreach (string str in row)
			{
				ListViewItem listViewItem = lvPraticien.Items.Add(nomsChamps[i]);
				listViewItem.SubItems.Add(str);
				i++;
			}
		}
	}
}

