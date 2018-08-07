using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegues
{
    class Program
    {
        public delegate void delegue(string message);
        static void Main(string[] args)
        {
            var monDelegue = new delegue(AfficherMessage);
            Console.WriteLine("entier1:");
            var entier1 = int.Parse(Console.ReadLine());
            Console.WriteLine("entier2:");
            var entier2 = int.Parse(Console.ReadLine());

            CalculerSomme(entier1, entier2, monDelegue);

            Console.ReadKey();
        }

        public static void CalculerSomme(int entier1, entier2, delegue methodePourAfficher)
        {
            var resultat = entier1 + entier2;
            methodePourAfficher($"La somme est:{resultat}");

        }

        public static void AfficherMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static int saisirEntier();
    }
}
