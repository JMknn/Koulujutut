using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkoharjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("anna luku ");
            luku = int.Parse(Console.ReadLine());

            switch (luku) {


                case 1:

                    Console.WriteLine("yksi");

                    break;

                case 2:

                    Console.WriteLine("kaksi");

                    break;

                case 3:

                    Console.WriteLine("kolme");
                    break;

                default:

                    Console.WriteLine("annoit jonkun muun luvun");

                        break;


                ;
            }
            }
        }
    }
  
