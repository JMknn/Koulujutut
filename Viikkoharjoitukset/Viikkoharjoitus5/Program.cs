using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkoharjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekuntti;
            Console.Write("Anna sekuntti määrä ");
            sekuntti = int.Parse(Console.ReadLine());

            
            Decimal tunti = (decimal)sekuntti / 3600;
        
            Decimal minuutti = (decimal)sekuntti / 60;

            Console.WriteLine("{0:0.###} tuntia ,{1:0.###} minuuttia,{2:0.###} sekunttia  ", tunti, (minuutti), (sekuntti));



        }
    }
}
