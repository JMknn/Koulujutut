using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
     class Program
    {
       static void Main(string[] args)
        {
            TestaaKiuas();
        }
        // joku testi emt
        static void TestaaKiuas()
        {
            Kiuas kiuas = new JAMK.IT.Kiuas();
            // päälle ja lämpöä ja kosteuttuaaa
            kiuas.Onkspäällä = true;
            kiuas.Lämpötila = 90F;
            kiuas.Kosteus = 50;
            Console.WriteLine("Kiuas o päällä {0}", kiuas.Onkspäällä);
            Console.WriteLine("Kiuas o lämpötilas {0}", kiuas.Lämpötila);
            Console.WriteLine("Kiuakaan kosteus = {0}", kiuas.Kosteus);

        }
    }
}
