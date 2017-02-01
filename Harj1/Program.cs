using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Harj4
{
    class Program
    {
        static void Main(string[] args)
        {
            teksti();
        }
        static void teksti()
        {
            string riviloppu;
            string minunkansio = @"d:\k8964\tekstikansio.txt";
            bool repeat = true;

            while (repeat == true)
            {
            Console.Write("Anna tekstiä ('0' niin loppuu ) : ");
            riviloppu = Console.ReadLine();
            if (riviloppu == "0") { repeat = false; }
            else
            {
                    try
                    {
                    using (StreamWriter writer = new StreamWriter(minunkansio, true))
                    {
                    writer.WriteLine(riviloppu);
                    }
                    }
                    catch (Exception ex)
                    {
                    Console.WriteLine(ex.Message);
                    }
                }
            }
            Console.WriteLine("Sisältö " + minunkansio + ":");
            try
            {
            List<string> rivi = new List<string>(File.ReadAllLines(minunkansio));
            foreach (string RIVI in rivi) {Console.WriteLine(RIVI);}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

