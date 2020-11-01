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
	public class DAOTypePraticien
	{
		private static TypePraticien CreerTypePraticien(DataRow row)
		{
			TypePraticien typePraticien = new TypePraticien();
			typePraticien.Code = row["TYP_CODE"].ToString();
			typePraticien.Libelle = row["TYP_LIBELLE"].ToString();
			typePraticien.Lieu = row["TYP_LIEU"].ToString();

			return typePraticien;
		}

		public static TypePraticien GetPraticien(string typeCode)
		{
			TypePraticien typepraticien = null;
			string selectInfosTypePraticien = "SELECT TYP_CODE, TYP_LIBELLE, TYP_LIEU FROM TYPEPRATICIEN WHERE TYP_CODE='" + typeCode + "'";
			DataTable dataTable = DBInterface.Select(selectInfosTypePraticien);
			if (dataTable != null)
			{
				typepraticien = CreerTypePraticien(dataTable.Rows[0]);
				
			}
			return typepraticien;
		}



}
}
