using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaElektrika
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ElektrikaEntities1 db = new ElektrikaEntities1();

            var x1 = db.Meritve.Select(a => new { a.ZapisČas, a.kW1 }).Take(10);

            foreach (var x in x1)
            {

                Console.WriteLine(x.ZapisČas + " " + x.kW1);

                Console.ReadLine();

            }
        }
    }
}
