using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6
{
    class juttu
    {
        public bool palaa { get; set; }

        public string Lampunvari { get; set; }
        public float LampunWatti { get; set; }

        int kirkkaus;
        public int LampunKirkkaus

        {
            get { return kirkkaus; }
            set
            {
                kirkkaus = value;

                if (kirkkaus < 0 || kirkkaus > 100)
                {
                    kirkkaus = 0;
                }
            }
        }
        public juttu(bool Palaa, string lampunvari, int lampunkirkkaus, float lampunWatti)
        {
            palaa = Palaa;
            if (palaa == true)
            {
                this.LampunWatti = lampunWatti;
                this.Lampunvari = lampunvari;
                this.LampunKirkkaus = lampunkirkkaus;
            }
            else
            {
                this.LampunWatti = 0;
                this.Lampunvari = "Tämä lamppu ei ole päällä";
                this.LampunKirkkaus = 0;
            }
            {
                                        // täs ei falsel tuu oikeeta tulosta
            }

        }
    }
}
