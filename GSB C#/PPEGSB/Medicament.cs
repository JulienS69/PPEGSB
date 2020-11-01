using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{

	public class Medicament
	{
		#region Attributs privés
		private string _depotLegal;
		private string _nomCommercial;
		private string _composition;
		private string _effets;
		private string _contreIndications;
		private double _prixEchantillon;
		#endregion

		#region Constructeurs
		public Medicament()
		{
			DepotLegal = NomCommercial = Composition = Effets = ContreIndications = "Aucun";
			PrixEchantillon = 0;
		}
		public Medicament(string DepotLegal, string NomCommercial, string Composition, string Effets, string ContreIndications, double PrixEchantillon)
		{
			this.DepotLegal = DepotLegal;
			this.NomCommercial = NomCommercial;
			this.Composition = Composition;
			this.Effets = Effets;
			this.ContreIndications = ContreIndications;
			this.PrixEchantillon = PrixEchantillon;
		}
		#endregion

		#region Propriétes
		public string DepotLegal { get => _depotLegal; set => _depotLegal = value; }
		public string NomCommercial { get => _nomCommercial; set => _nomCommercial = value; }
		public string Composition { get => _composition; set => _composition = value; }
		public string Effets { get => _effets; set => _effets = value; }
		public string ContreIndications { get => _contreIndications; set => _contreIndications = value; }
		public double PrixEchantillon { get => _prixEchantillon; set => _prixEchantillon = value; }
		#endregion
	}
}
