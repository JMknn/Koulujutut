using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus1
{
    class Dynamohissi
    {
        public int nykynenkerros { get; set; }
        private int kohdekerros { get; set; }
        public string kerros { get; set; }

        public int Kohrekerros
        {
            get
            { return kohdekerros; }
            set
            {
                if (value >= 1 || value <= 5)
                {

                    this.nykynenkerros = value;

                    kerros = "Hissi on nyt kerroksessa: " + nykynenkerros;
                }

                else kerros = " Annettu kerros numero pitää olla välillä 1-5";


            }

        }
    }
}
