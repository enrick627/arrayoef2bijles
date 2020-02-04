//Enrick De Munter nr3 5ITN
/*  OPGAVE
 *  ======
 *  3 namen vragen en gesorteerd zetten  en in hoofdletters
 *
 *  UPGRADE
 *      eerste letter van voornaam punt de achternaam en dit allemaal in hoofdletters(J.Met De Pet)
 *
 *
 *  ANALYSE
 *  ======
 * 
 *
 *
 *
 */
using System;

namespace OefNamen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //DECLARATIES
            string[] namen = new string[3];
            //  VRAAG
            //           herhaal 3x
            //          vraag naam
            for (int aantalNamen = 0; aantalNamen < 3; aantalNamen++)
            {
                Console.WriteLine("geef naam?");
                namen[aantalNamen] = Console.ReadLine();
            }
            //  BEREKEN
            //           Zet de naam in alfabetische volgorde
            Array.Sort(namen);
            foreach (string naam in namen)
            {
                //  TOON
                //           De namen alfabetisch
                Console.WriteLine((naam[0] + "." +
                    naam.Substring
                    (naam.IndexOf(" "))).ToUpper());
            }
            

            //wachten
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();

        }
    }
}
