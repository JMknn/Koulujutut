using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    
    class Program
    {
        static void Main(string[] args)
        {
            TestaaHenkiloRek();
        }
        static void TestaaHenkiloRek()
        {
            string id;

            Henkilot poppoo = new Henkilot();
            Henkilo hlo = new Henkilo { Etunimi = "Jack", Sukunimi = "Russell", Hetu = "abc" };
            Henkilo hlo1 = new Henkilo { Etunimi = "Jack", Sukunimi = "Russell", Hetu = "123" };
            Henkilo hlo2 = new Henkilo { Etunimi = "Jack", Sukunimi = "Russell", Hetu = "456" };
            
            poppoo.LisaaHenkilo(hlo);
            poppoo.LisaaHenkilo(hlo1);
            poppoo.LisaaHenkilo(hlo2);

            foreach (Henkilo h in poppoo.Henkilolista)
            {
                Console.WriteLine("{0}", h.ToString());
            }
            id = Console.ReadLine();
            Console.WriteLine(poppoo.HaeHenkiloHetulla(id));
            
        }
    }
}