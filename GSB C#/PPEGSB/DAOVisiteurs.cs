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
	public class DAOVisiteurs
	{
		///<summary>
		///Fournit la liste de tous les visiteurs.
		///</summary>
		///<returns>
		///Une collection (list) de visiteurs
		///</returns>
		public static List<Visiteur> GetVisiteurs()
		{
			List<Visiteur> visiteurs = null;
			string selectVisiteurs = "SELECT VIS_MATRICULE, VIS_NOM, VIS_PRENOM, VIS_ADRESSE, VIS_CP, VIS_VILLE, VIS_DATEEMBAUCHE FROM VISITEUR;";
			DataTable dataTable = DBInterface.Select(selectVisiteurs);
			//Le Datatable retourné est transformé en collection de médicaments
			if (dataTable != null)
			{
				visiteurs = new List<Visiteur>();
				foreach (DataRow row in dataTable.Rows)
				{
					Visiteur visiteur = CreerVisiteur(row); ;
					visiteurs.Add(visiteur);
				}
			}
			return visiteurs;
		}

		//Construction d'une instance de visiteur à partir d'une ligne du résultat de la requête.
		//Rappel : on souhaite que la couche "Présentation" ne soit pas liée à la base de données.
		//Elle ne doit travailler qu'avec des objets métiers.
		private static Visiteur CreerVisiteur(DataRow row)
		{
			Visiteur visiteur = new Visiteur();
			visiteur.Matricule = row["VIS_MATRICULE"].ToString();
			visiteur.Nom = row["VIS_NOM"].ToString();
			visiteur.Prenom = row["VIS_PRENOM"].ToString();
			visiteur.Adresse = row["VIS_ADRESSE"].ToString();
			visiteur.Cp = row["VIS_CP"].ToString();
			visiteur.Ville = row["VIS_VILLE"].ToString();
			visiteur.DateEmbauche = row["VIS_DATEEMBAUCHE"].ToString();
			return visiteur;
		}
	}
}
