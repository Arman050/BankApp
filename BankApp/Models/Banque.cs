using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class Banque
    {
        #region Fields

        private string _name;
        private List<Courant> _courants = new List<Courant>();

        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<Courant> Courants
        {
            get { return _courants; }
        }

        public Courant this[string num]
        {
            get
            {
                foreach (Courant c in Courants)
                {
                    if (c.Numero == num)
                    {
                        return c;
                    }
                }
                Console.WriteLine($"Le compte numéro {num} n'existe pas");
                return null;
            }
        }

        #endregion

        #region Methodes

        public void Ajouter(Courant c)
        {
            foreach (Courant courant in Courants)
            {
                if (courant.Numero == c.Numero)
                {
                    Console.WriteLine("Le compte existe déjà !");
                    return;
                }
            }
            _courants.Add(c);
        }

        public void Supprimer(string num)
        {
            Courant? c = this[num];
            if (c is null)
            {
                Console.WriteLine($"Le compte numéro : {num} n'existe pas !");
            }
            Courants.Remove(c);
        }

        #endregion
    }
}
