﻿using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BankSystem
//{
//    internal class Banque
//    {
//        public class Personne
//        {
//            #region Fields
//            private string _nom;
//            private string _prenom;
//            private DateTime _dateNaiss;
//            #endregion

//            #region Properties
//            public string Nom
//            {
//                get { return _nom; }
//                set { _nom = value; }
//            }

//            public string Prenom
//            {
//                get { return _prenom; }
//                set { _prenom = value; }
//            }

//            public DateTime DateNaiss
//            {
//                get { return _dateNaiss; }
//                set
//                {
//                    // TODO : trouver la meilleure facon de calculer l'âge
//                    if (DateTime.Now.Year - value.Year >= 18)
//                    {
//                        _dateNaiss = value;
//                    }
//                    else
//                    {
//                        // A remplacer par la suite par un throw car console n'existe pas
//                        // les projets console donc pas très portable!
//                        Console.WriteLine("Vous n'êtes pas majeur !");
//                    }

//                }
//            }
//            #endregion
//        }

//        public class Courant
//        {
//            #region Fields
//            private string _numero;
//            private double _solde;
//            private double _ligneDeCredit;
//            private Personne _titulaire;
//            private double _GetSolde;
//            #endregion

//            #region Propreties
//            public string Numero
//            {
//                get { return _numero; }
//                set
//                {
//                    // Check modulo97
//                    _numero = value;
//                }
//            }
//            public double Solde
//            {
//                get { return _solde; }
//                private set
//                {
//                    if (value > -LigneDeCredit)
//                    {
//                        _solde = value;
//                    }
//                    else
//                    {
//                        // Même considération pour le cw pour les props
//                        Console.WriteLine("Vous dépassez votre ligne de crédit !!!");
//                    }
//                }
//            }
//            public double LigneDeCredit
//            {
//                get
//                { return _ligneDeCredit; }

//                set
//                {
//                    if (value >= 0)
//                    {
//                        _ligneDeCredit = value;
//                    }
//                    else
//                    {
//                        // Même remarque que pour la propriété dans Personne 
//                        Console.WriteLine("Votre ligne de crédit doit être positive");
//                    }

//                }
//            }
//            public Personne Titulaire
//            {
//                get { return _titulaire; }
//                set { _titulaire = value; }
//            }

//            public double GetSolde()
//            {
//               return Solde;
//            }

//            #endregion

//            #region Retrait
//            public void Retrait(double montant)
//            {
//                if (montant > 0)
//                {
//                    Solde = Solde - montant;
//                }
//                else
//                {
//                    // Même considération pour le cw pour les props
//                    Console.WriteLine("Le montant doit être positif");
//                }
//            }
//            #endregion

//            #region Depot
//            public void Depot(double montant)
//            {
//                if (montant > 0)
//                {
//                    Solde += montant;
//                }
//                else
//                {
//                    // Même considération pour le cw pour les props
//                    Console.WriteLine("Le montant doit être positif");
//                }
//            }
//            #endregion

//        }

//    }
//}
