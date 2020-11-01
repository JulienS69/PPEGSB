using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class TypePraticien
    {
        #region Attributs privés
        private string _code;
        private string _libelle;
        private string _lieu;
        #endregion

        #region Constructeurs
        public TypePraticien()
        {
            _code = _libelle = _lieu = "Aucun";
        }
        public TypePraticien(string code, string libelle, string lieu)
        {
            this._code = code;
            this._libelle = libelle;
            this._lieu = lieu;
        }

        public string Code { get => _code; set => _code = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }
        public string Lieu { get => _lieu; set => _lieu = value; }
        #endregion


    }
}
