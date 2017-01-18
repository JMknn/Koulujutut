using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harjoitus6;

namespace Harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaValaistus();
        }
        static void TestaaValaistus()
        {
            bool palaa;
            string Lampunvari;
            int LampunKirkkaus;
            float LampunWatti;
            
                Console.WriteLine("onko lamppu päällä(true/false):");
                palaa = bool.Parse(Console.ReadLine());

            Console.WriteLine("Mitä väriä lamppu on ? ");
            Lampunvari = Console.ReadLine();

            Console.WriteLine("Mikä on lampun kirkkaus? ");
            LampunKirkkaus = int.Parse(Console.ReadLine());

            Console.WriteLine("Mikäs on lampun teho ? ");
            LampunWatti = float.Parse(Console.ReadLine());

            juttu lamppu1 = new juttu (palaa, Lampunvari, LampunKirkkaus, LampunWatti);
            Console.WriteLine("Lamppu palaa " + palaa + ",lampun väri:" + Lampunvari + ", lampun kirkkaus : " + LampunKirkkaus +" % "+ " ja sen teho on: " + LampunWatti +" W ");




            
        }
    }

}
