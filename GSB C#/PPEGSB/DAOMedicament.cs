using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Metier;
using Persistance;

namespace DAO
{
	public class DAOMedicament
	{
		///<summary>
		///Fournit la liste de tous les médicaments.
		///</summary>
		///<returns>
		///Une collection (list) de médicaments
		///</returns>
		public static List<Medicament> GetMedicaments()
		{
			List <Medicament> medicaments  = null;
			string selectMedicaments = "SELECT MED_DEPOTLEGAL, MED_NOMCOMMERCIAL, MED_COMPOSITION, MED_EFFETS, MED_CONTREINDIC, MED_PRIXECHANTILLON FROM MEDICAMENT";
			DataTable dataTable = DBInterface.Select(selectMedicaments);
			//Le Datatable retourné est transformé en collection de médicaments
			if (dataTable != null)
			{
				medicaments = new List<Medicament>();
				foreach (DataRow row in dataTable.Rows)
				{
					Medicament medic = CreerMedicament(row); ;
					medicaments.Add(medic);
				}
			}
			return medicaments;
		}

		//Construction d'une instance de médicaments à partir d'une ligne du résultat de la requête.
		//Rappel : on souhaite que la couche "Présentation" ne soit pas liée à la base de données.
		//Elle ne doit travailler qu'avec des objets métiers.
		private static Medicament CreerMedicament(DataRow row)
		{
			Medicament medicament = new Medicament();
			medicament.DepotLegal = row["MED_DEPOTLEGAL"].ToString();
			medicament.NomCommercial = row["MED_NOMCOMMERCIAL"].ToString();
			medicament.Composition = row["MED_COMPOSITION"].ToString();
			medicament.Effets = row["MED_EFFETS"].ToString();
			medicament.ContreIndications = row["MED_CONTREINDIC"].ToString();
			if (row["MED_PRIXECHANTILLON"].ToString() != "")
			{
				medicament.PrixEchantillon = Convert.ToDouble(row["MED_PRIXECHANTILLON"].ToString());
			}
			else
			{
				medicament.PrixEchantillon = 0;
			}
			return medicament;
		}
	}
}
