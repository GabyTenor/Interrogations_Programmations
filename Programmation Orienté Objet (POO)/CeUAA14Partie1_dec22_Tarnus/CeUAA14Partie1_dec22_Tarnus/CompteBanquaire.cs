using System;
using System.Collections.Generic;
using System.Text;

namespace CeUAA14Partie1_dec22_Tarnus
{
    class CompteBanquaire
    {
        private string _nomProp;
        private double _fonds;
        private string _numCompte;

        public CompteBanquaire(string nomProp, double fonds, string numCompte)
        {
            this._nomProp = nomProp;
            this._fonds = fonds;
            this._numCompte = numCompte;
        }

        public string NomProp
        {
            get { return _nomProp; }
            set { _nomProp = value; }
        }

        public double Fonds
        {
            get { return _fonds; }
            set { _fonds = value; }
        }

        public string NumCompte
        {
            get { return _numCompte; }
            set { _numCompte = value; }
        }

        public void VoirComptesEtInfos(int parcourPers, double action, CompteBanquaire[] personnes)
        {
            Console.WriteLine("Le copte numéro " + _numCompte + " au nom de " + _nomProp + " " + (parcourPers + 1) + " a un solde de " + _fonds);

            if (action == 1 && parcourPers == personnes.Length - 1)
            {
                Console.WriteLine("Il reste " + personnes[0]._fonds + " sur le compte " + personnes[0]._numCompte); ;
            }
        }

        public void Transaction(double action, ref CompteBanquaire[] personnes, int k)
        {
            switch (action)
            {
                case 1:
                    if (SiAssezDargent(personnes, 0, k * 100))
                    {
                        _fonds += k * 100;
                        personnes[0]._fonds -= k * 100;
                    }
                    break;

                case 2:
                    if (SiAssezDargent(personnes, 2, 500))
                    {
                        _fonds += 500;
                        personnes[2]._fonds -= 500;
                    }              
                    break;

                case 3:
                    if (SiAssezDargent(personnes, 1, 1000))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Solde insuffisant sur le compte " + _numCompte + " pour faire le versement");
                    }
                    break;

                default:
                    
                    break;
            }
           
        }

        public bool SiAssezDargent(CompteBanquaire[] personnes, int l, int m)
        {
            bool assezDargent = false;

            if(personnes[l]._fonds > m)
            {
                assezDargent = true;
            }

            return assezDargent;
        }
    }
}
