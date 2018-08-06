using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammouth
{
    class Program
    {
        public static readonly string mot = "mammouth";

        static void Main(string[] args)
        {
            FrequenceLettre();
            Console.ReadKey();
        }

        //requete pour renvoyer la fréquence de chaque lettre
        public static void FrequenceLettre()
        {


            var requete = from lettre in mot //boucle sur chaque lettre du mot
                          group lettre by lettre into groupe
                          //orderby groupe.Key ascending
                          select new
                          {
                              Lettre = groupe.Key,
                              NbLettres = groupe.Count()
                          };
            foreach (var resultat in requete)
            {
                Console.WriteLine($"{resultat.Lettre} + {resultat.NbLettres}");
                
                Console.WriteLine("*********");
            }

        }

    }
}

