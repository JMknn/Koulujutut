using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1;
            Console.Write("Anna luku ");
            luku1 = int.Parse(Console.ReadLine());

            int luku2;
            Console.Write("Anna luku ");
            luku2 = int.Parse(Console.ReadLine());

            int luku3;
            Console.Write("Anna luku ");
            luku3 = int.Parse(Console.ReadLine());

            int[] array1 = { luku1, luku2, luku3};
            int sum1 = array1.Sum();
            Console.WriteLine(sum1 );


            decimal result = (decimal)sum1 / array1.Length;
            Console.WriteLine(result);



        }
    }
}
