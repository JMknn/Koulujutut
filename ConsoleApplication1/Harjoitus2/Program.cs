using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harjoitus2;

namespace Harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            pesukone1();
        }
        static void pesukone1()
        {
            pesuk Pesuk = new Harjoitus2.pesuk();

            Pesuk.Malli = "pesugone";
            Pesuk.Onkopäällä = true;
            Pesuk.Moodi = "Rahanpesu";
            Pesuk.Pesuvedensyöttö = true;
          
            Pesuk.Pesulämpö = 40F;
            Pesuk.Pesuaika = 1;
            Console.WriteLine("Pesukoneen malli on {0}", Pesuk.Malli);

            Console.WriteLine("Pesukone on päällä {0}", Pesuk.Onkopäällä);
            Console.WriteLine("Käytettävä pesu ohjelma on {0}",Pesuk.Moodi);
            Console.WriteLine("Pesukoneeseen tulee vesi {0}", Pesuk.Pesuvedensyöttö);
            Console.WriteLine("Pesukoneen lämpötila on {0} C°", Pesuk.Pesulämpö);
            Console.WriteLine("Pesukone pesee {0} h", Pesuk.Pesuaika);
            
        }
    }
}
