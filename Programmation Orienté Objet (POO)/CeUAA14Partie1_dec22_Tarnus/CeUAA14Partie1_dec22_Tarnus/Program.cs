using System;

namespace CeUAA14Partie1_dec22_Tarnus
{
    class Program
    {
        static void Main(string[] args)
        {
            double virementPredef = 500;

            int nbrPersonnes = 10;
            CompteBanquaire[] personnes = new CompteBanquaire[nbrPersonnes];

            Console.WriteLine("Bienvenue dans la banque du centre Asty-Moulin !");
            Console.WriteLine("\n" + "---------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Préparation des comptes : ");

            for (int i = 0; i < personnes.Length; i++)
            {
                if(i == 0)
                {
                    personnes[i] = new CompteBanquaire("personne", 20000, "BE433500064678" + i + "1");
                }
                else
                {
                    personnes[i] = new CompteBanquaire("personne", 200, "BE433500064678" + i + "1");
                }
                
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            for (int j = 0; j < personnes.Length; j++)
            {
                personnes[j].VoirComptesEtInfos(j, 1, personnes);
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Versement de la personne 1 vers les autre comptes");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            for (int k = 1; k < personnes.Length; k++)
            {
                personnes[k].Transaction(1, ref personnes, k);

                personnes[k].VoirComptesEtInfos(k, 1, personnes);
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Versement de " + virementPredef + " Euros du compte de la personne 3 sur le compte de la personne 1");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            personnes[0].Transaction(2, ref personnes, 2);

            personnes[3].Transaction(3, ref personnes, 1);

            Console.ReadLine();
        }
    }
}
