using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class Personne
    {
        #region Fields
        private string _nom;
        private string _prenom;
        private DateTime _dateNaiss;
        #endregion

        #region Properties
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public DateTime DateNaiss
        {
            get { return _dateNaiss; }
            set
            {
                // TODO : trouver la meilleure facon de calculer l'âge
                if (DateTime.Now.Year - value.Year >= 18)
                {
                    _dateNaiss = value;
                }
                else
                {
                    // A remplacer par la suite par un throw car console n'existe pas
                    // les projets console donc pas très portable!
                    Console.WriteLine("Vous n'êtes pas majeur !");
                }

            }
        }
        #endregion
    }
}
