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
	public class DAORapportVisite
	{
		///<summary>
		///Fournit la liste de tous les rapports de visite.
		///</summary>
		///<returns>
		///Une collection (list) de rapports de visite.
		///</returns>
		public static List<RapportDeVisite> GetRapports()
		{
			List<RapportDeVisite> rapports = null;
			string selectRapports = "SELECT RAP_NUM, RAP_DATE, RAP_BILAN, RAP_MOTIF, PRA_NUM, VIS_MATRICULE FROM RAPPORTVISITE;";
			DataTable dataTable = DBInterface.Select(selectRapports);
			//Le Datatable retourné est transformé en collection de rapports de visite
			if (dataTable != null)
			{
				rapports = new List<RapportDeVisite>();
				foreach (DataRow row in dataTable.Rows)
				{
					RapportDeVisite rapport = CreerRapport(row); ;
					rapports.Add(rapport);
				}
			}
			return rapports;
		}

		//Construction d'une instance de Rapport de visite à partir d'une ligne du résultat de la requête.
		//Rappel : on souhaite que la couche "Présentation" ne soit pas liée à la base de données.
		//Elle ne doit travailler qu'avec des objets métiers.
		private static RapportDeVisite CreerRapport(DataRow row)
		{
			RapportDeVisite rapport = new RapportDeVisite();
			rapport.Numéro = row["RAP_NUM"].ToString();
			char[] separateurs = new char[] { '/', ':', ' ', '-' };
			List<string> eltDate = new List<string>(row["RAP_DATE"].ToString().Split(separateurs));
			DateTime newDate = new DateTime(Convert.ToInt32(eltDate[2]), Convert.ToInt32(eltDate[1]), Convert.ToInt32(eltDate[0]), Convert.ToInt32(eltDate[3]), Convert.ToInt32(eltDate[4]), Convert.ToInt32(eltDate[5]));
			string sqlFormattedDate = newDate.ToString("yyyy-MM-dd HH:mm:ss");
			rapport.Date = sqlFormattedDate;
			rapport.Bilan = row["RAP_BILAN"].ToString();
			rapport.Motif = row["RAP_MOTIF"].ToString();
			rapport.MatriculeVisiteur = row["VIS_MATRICULE"].ToString();

			
			if (row["PRA_NUM"].ToString() != "")
			{
				rapport.NuméroPraticien = Convert.ToInt32(row["PRA_NUM"].ToString());
			}
			else
			{
				rapport.NuméroPraticien = 0;
			}
			return rapport;
		}

		public static Boolean UpdateRapport(RapportDeVisite rapport)
		{
			string updateRapport = "UPDATE RAPPORTVISITE SET RAP_DATE='" + rapport.Date + "', RAP_BILAN='" + rapport.Bilan + "', RAP_MOTIF='" + rapport.Motif + "', PRA_NUM='" + rapport.NuméroPraticien.ToString() + "' WHERE RAP_NUM='" + rapport.Numéro + "';";
			int updatedRows = DBInterface.Update(updateRapport);
			if (updatedRows > 0)
			{
				return true;
			} 
			else
			{
				return false;
			}
		}

		public static Boolean CreateRapport(RapportDeVisite rapport)
		{
			RapportDeVisite nouveauRapport = null;
			string createRapport = "INSERT INTO RAPPORTVISITE VALUES ('" + rapport.Numéro + "', '" + rapport.Date + "', '" + rapport.Bilan + "', '" + rapport.Motif + "', '" + rapport.NuméroPraticien + "', '" + rapport.MatriculeVisiteur + "');";
			int updatedRows = DBInterface.Update(createRapport);
			if (updatedRows > 0)
			{
				return true;
			}
			else 
			{
				return false;
			}
		}
	}
}
