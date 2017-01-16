using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkoharjoitus8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero  = new int[3];
            for (int i = 0; i < 3; i++)

            {
                Console.Write("Anna numero ");
            
                numero[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numero);
            Console.WriteLine("Suurin luku oli {0}", numero[2]);

            

           


        }
    }
}
