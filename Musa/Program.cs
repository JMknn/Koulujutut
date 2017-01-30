using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musa;

namespace Musa
{
    class Program
    {
        static void Main(string[] args)
        {
            Kappaleet kappale = new Kappaleet();
            Ceedee kappale1 = new Ceedee { Kappalenimi = "biisi1", Pituus = "4:55" };
            Ceedee kappale2 = new Ceedee { Kappalenimi = "biisi2", Pituus = "4:35" };
            Ceedee kappale3 = new Ceedee { Kappalenimi = "biisi3", Pituus = "4:15" };
            Ceedee kappale4 = new Ceedee { Kappalenimi = "biisi4", Pituus = "6:55" };

            kappale.Lisaakappale(kappale1);
            kappale.Lisaakappale(kappale2);
            kappale.Lisaakappale(kappale3);
            kappale.Lisaakappale(kappale4);

             foreach (Ceedee k in kappale.Kappalelista)
            {
                Console.WriteLine("{0}", k.ToString());
            }


        }
    }
}
