using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkoharjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int luku;
                Console.Write("Paljon sait pisteitä? ");
                luku = int.Parse(Console.ReadLine());

                if (luku==0 || luku==1)
                { Console.Write("Numerosi on 0 "); }

                else if (luku == 2 || luku == 3)
                { Console.Write("Numerosi on 1 "); }


                else if (luku == 4 || luku == 5)
                { Console.Write("Numerosi on 2 "); }


                else if (luku == 6 || luku == 7)
                { Console.Write("Numerosi on 3 "); }


                else if (luku == 8 || luku == 9)
                { Console.Write("Numerosi on 4 "); }
                 
                else if (luku == 10 || luku == 11 || luku== 12)
                { Console.Write("Numerosi on 5 "); }
            }
        }
    }
}
