using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkoharjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            int matka;
            Console.Write("Minkä matkan ajoit? ");
            matka = int.Parse(Console.ReadLine());
            Double bensakulutus;
            bensakulutus = 0.0702 * matka;
            Double bensahinta;
            bensahinta = 1.595 * bensakulutus;
            Console.WriteLine("Bensaa menee {0:0.00} Litraa , mikä maksaa {1:0.0} ", bensakulutus, bensahinta);
        }
    }
}
