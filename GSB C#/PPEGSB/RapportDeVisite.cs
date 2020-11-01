using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{

	public class RapportDeVisite
	{
		#region Attributs privés
		private string _numéro;
		private string _date;
		private string _bilan;
		private string _motif;
		private int _numéroPraticien;
		private string _matriculeVisiteur;
		#endregion

		#region Constructeurs
		public RapportDeVisite()
		{
			Numéro = Bilan = Motif = MatriculeVisiteur = "Aucun";
			Date = "DATE '1970-01-01'";
			NuméroPraticien = 0;
		}
		public RapportDeVisite(string Numéro, string Date, string Bilan, string Motif, int NuméroPraticien, string MatriculeVisiteur)
		{
			this.Numéro = Numéro;
			this.Date = Date;
			this.Bilan = Bilan;
			this.Motif = Motif;
			this.NuméroPraticien = NuméroPraticien;
			this.MatriculeVisiteur = MatriculeVisiteur;
		}
		#endregion

		#region Propriétes
		public string Numéro { get => _numéro; set => _numéro = value; }
		public string Date { get => _date; set => _date = value; }
		public string Bilan { get => _bilan; set => _bilan = value; }
		public string Motif { get => _motif; set => _motif = value; }
		public int NuméroPraticien { get => _numéroPraticien; set => _numéroPraticien = value; }
		public string MatriculeVisiteur { get => _matriculeVisiteur; set => _matriculeVisiteur = value; }
		#endregion
	}
}
