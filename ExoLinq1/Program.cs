using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ExoLinq1
{
    class Program
    {

        private static readonly int[] scores = new int [] {97,92,81,60};

        //requête pour scores supérieurs à 80
        private static void ScoresSuperieurs80()
        {
            var requete = from score in scores
                          orderby score ascending
                          where score > 80
                          select score;
            Console.WriteLine("Scores supérieurs à 80");
            foreach (var resultat in requete)
            {
                Console.WriteLine(resultat);
            }

        }
        
        // requête pour scores dans l'ordre croissant
        private static void ScoresOrdreCroissant()
        {
            var requete = from score in scores
                          orderby score ascending
                          select score;
            Console.WriteLine("\nScores dans l'ordre croissant");
            foreach (var resultat in requete)
            {
                Console.WriteLine(resultat);
            }
        }

        static void Main(string[] args)
        {
            ScoresSuperieurs80();
            ScoresOrdreCroissant();
            Console.ReadKey();
        }
    }
}
