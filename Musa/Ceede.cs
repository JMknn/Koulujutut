using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musa;

namespace Musa
{
    class Ceedee
    {
        public string Kappalenimi { get; set; }
        public string Pituus { get; set; }

        public override string ToString()
        {
            return Kappalenimi + " " + Pituus + " ";
        }
       }
    class Kappaleet
    {
        private List<Ceedee> kappaleet;
        public List<Ceedee> Kappalelista
        {
            get { return kappaleet; }
        }
        public Kappaleet ()
        {
            kappaleet = new List<Ceedee>();
        }
        public void Lisaakappale(Ceedee cd)
        {
            kappaleet.Add(cd);
        }

}
}

