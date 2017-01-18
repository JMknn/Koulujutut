using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harjoitus3;




namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Telkka();
        }
        static void Telkka()
        {
            TV Telkka = new Harjoitus3.TV();
            Telkka.Malli = "sämsång";
            Telkka.Onkopäällä = true;
            Telkka.Signaali = true;
            Telkka.Kanava = 4;


            Console.WriteLine("Telkan malli on {0}",Telkka.Malli);
            if (Telkka.Onkopäällä == true)
            {

                Console.WriteLine("Telkka on päällä ");
            }
            else
            {
                Console.WriteLine("Telkka ei oo päällä");      
            }
            if (Telkka.Signaali == true)
            {

                Console.WriteLine("Telkkaan tulee signaali ");
            }
            else
            {
                Console.WriteLine("Ei signaalia");
            }
            
            Console.WriteLine("Telkas päällä kanava {0} ", Telkka.Kanava);
            

        }
    }

}
          
