using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi
{
    internal class Program
    {
        delegate bool funkcija_za_nize(string s);

        static void Main(string[] args)
        {

            string[] imena = { "Blaž", "Neža", "Erik", "Simon", "Jure", "Mitja" };
            List<string> x = delaj_operacije_na_nize(imena, začnesS);
            List<string> y = delaj_operacije_na_nize(imena, končazN);

            foreach (var item in y)

            {
                Console.WriteLine(item);

            }

            //List<string> naS = new List<string>();

            /*
            foreach (var ime in imena)
            {
                if (ime.StartsWith("S"))
                {
                    naS.Add(ime);
                    Console.WriteLine(ime);
                }
            }
            */

            Console.ReadLine();
        }

        static List<string> delaj_operacije_na_nize(string[] mojNizi, funkcija_za_nize mojaFunkcija)
        {
            List<string> rezultat = new List<string>();

            foreach (string v in mojNizi)
            {

                if (mojaFunkcija(v))
                    rezultat.Add(v);

            }

            return rezultat;
        }

        static bool začnesS(string s)
        {
            return s.StartsWith("S");
        }

        static bool končazN(string s)
        {
            return s.EndsWith("n");
        }
    }
}
