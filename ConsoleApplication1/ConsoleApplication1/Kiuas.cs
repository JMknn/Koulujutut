using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{

   public class Kiuas
    {
        public bool Onkspäällä   {get;set;}
        public float Lämpötila { get; set; }
        float kosteus;
        public float Kosteus {
            get
            { return kosteus; }
            set
            {

                kosteus = value;
                if (kosteus < 0 || kosteus > 100)
                {
                    kosteus = 0;
                }
            }
        }
    }
}
