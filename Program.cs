using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        Program()
        {
            CatiaConnection cc = new CatiaConnection();
           if( cc.laeuftCatia())
            {
                Console.WriteLine("1 CATIA läuft");

                cc.erzeugePart();
                Console.WriteLine("2 Part erstellt");

                cc.erstelleLeereSkizze();
                Console.WriteLine("3 Skizze erstellt");

                cc.erstelleSkizzenElemente();
                Console.WriteLine("4 Elemente erstellt");

                Console.WriteLine("Bitte Länge eingeben. ");
                Console.Write("Länge: ");
                double Laenge = Convert.ToDouble(Console.ReadLine());

                cc.erstelleBlock(Laenge);
                Console.WriteLine("5 Block erstellt");

            }
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
