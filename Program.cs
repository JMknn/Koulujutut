using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harjoitus1;


namespace Harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissitestaus();
        }

        static void Hissitestaus()
        {
            Dynamohissi hissi = new Dynamohissi();
            while (true)
            {
                Console.WriteLine("Hissi on nyt kerrokses : " + hissi.nykynenkerros);
                Console.Write("Anna haluamasi kerroksen numero ");
                hissi.Kohrekerros = int.Parse(Console.ReadLine());

            }
        }
    }
}
