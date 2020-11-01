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
    public class DAOPraticiens
    {
        ///<summary>
        ///Fournit la liste de tous les Praticiens.
        ///</summary>
        ///<returns>
        ///Une collection (list) de Praticiens
        ///</returns>
        public static List<Praticien> GetPraticien()
        {
            List<Praticien> praticiens = null;
            string selectPraticiens = "SELECT PRA_NUM, PRA_NOM, PRA_PRENOM, PRA_ADRESSE, PRA_CP, PRA_VILLE, PRA_COEFNOTORIETE, TYP_CODE FROM PRATICIEN";
            DataTable dataTable = DBInterface.Select(selectPraticiens);
            //Le Datatable retourné est transformé en collection de Client
            if (dataTable != null)
            {
                praticiens = new List<Praticien>();
                foreach (DataRow row in dataTable.Rows)
                {
                    Praticien praticien = CreerPraticien(row); ;
                    praticiens.Add(praticien);
                }
            }
            return praticiens;
        }

        public static Praticien GetPraticienParNomPrenom(string nom, string prenom)
        {
            Praticien praticien = null;
            string selectPraticien = "SELECT PRA_NUM, PRA_NOM, PRA_PRENOM, PRA_ADRESSE, PRA_CP, PRA_VILLE, PRA_COEFNOTORIETE, TYP_CODE FROM PRATICIEN WHERE PRA_NOM='" + nom + "' AND PRA_PRENOM='" + prenom + "'";
            DataTable dataTable = DBInterface.Select(selectPraticien);
            if (dataTable.Rows.Count != 0)
            {
                DataRow row = dataTable.Rows[0];
                praticien = CreerPraticien(row);
            }

            return praticien;
        }

        //Construction d'une instance de Client à partir d'une ligne du résultat de la requête.
        //Rappel : on souhaite que la couche "Présentation" ne soit pas liée à la base de données.
        //Elle ne doit travailler qu'avec des objets métiers.
        private static Praticien CreerPraticien(DataRow row)
        {
            Praticien praticien = new Praticien();
            praticien.Num = Convert.ToInt32(row["PRA_NUM"].ToString());
            praticien.Nom = row["PRA_NOM"].ToString();
            praticien.Prenom = row["PRA_PRENOM"].ToString();
            praticien.Adresse = row["PRA_ADRESSE"].ToString();
            praticien.Cp = row["PRA_CP"].ToString();
            praticien.Ville = row["PRA_VILLE"].ToString();
            praticien.CoefNotoriete = Convert.ToInt32(row["PRA_COEFNOTORIETE"].ToString());
            praticien.CodeTypePraticien = row["TYP_CODE"].ToString();

            return praticien;
        }

        public static List<Praticien> GetPraticiens() {
            List<Praticien> praticiens = null;
            string selectPraticiens = "SELECT PRA_NUM, PRA_NOM, PRA_PRENOM, PRA_ADRESSE, PRA_CP, PRA_VILLE, PRA_COEFNOTORIETE, TYP_CODE FROM PRATICIEN; ";
            DataTable dataTable = DBInterface.Select(selectPraticiens);
			    
			if (dataTable != null)
			{
				praticiens = new List<Praticien>();
				foreach (DataRow row in dataTable.Rows)
				{
					Praticien praticien = CreerPraticien(row); ;
					praticiens.Add(praticien);
				}
            }
			return praticiens;
        }
    }
}