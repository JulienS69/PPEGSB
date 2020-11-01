using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Praticien
    {
        #region Attributs privés
        private int _num;
        private string _nom;
        private string _prenom;
        private string _adresse;
        private string _cp;
        private string _ville;
        private int _coefNotoriete;
        private string _codeTypePraticien;
        #endregion

        #region Constructeurs
        public Praticien()
        {
            _nom = _prenom = _adresse = _cp = _ville = "Aucun";
        }
        public Praticien(int num, string nom, string prenom, string adresse, string cp, string ville, int coefNotoriete, string codeTypePraticien)
        {
            this._num = num;
            this._nom = nom;
            this._prenom = prenom;
            this._adresse = adresse;
            this._cp = cp;
            this._ville = ville;
            this._coefNotoriete = coefNotoriete;
            this._codeTypePraticien = codeTypePraticien;
        }

        public int Num { get => _num; set => _num = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public string Cp { get => _cp; set => _cp = value; }
        public string Ville { get => _ville; set => _ville = value; }
        public int CoefNotoriete { get => _coefNotoriete; set => _coefNotoriete = value; }
        public string CodeTypePraticien { get => _codeTypePraticien; set => _codeTypePraticien = value; }
        #endregion


    }
}
