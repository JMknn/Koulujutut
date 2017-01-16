using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkoharjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ika;
            Console.Write(" Kuinka vanha olet? ");
            ika = int.Parse(Console.ReadLine());

            if (ika <= 18)
            { Console.Write("Alaikäinen "); }

            else if (ika >= 18 && ika < 65)
            {
                Console.Write("Aikuinen ");
            }
            else
            {
                Console.Write("Seniori ");
            }
        }
    }
}
