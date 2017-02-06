using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaOstos();
        }
        static void TestaaOstos()
        {
        List<Ostos> ostokset = new List<Ostos>();
        ostokset.Add(new Ostos("Limsa", 5));
        ostokset.Add(new Ostos("Makkara", 4)); 
        ostokset.Add(new Ostos("Limppu", 3)); 
        ostokset.Add(new Ostos("ES ENERGIA JUOMA", 5));  
        
    Console.WriteLine("Kaikki kärryssä olevat ostokset ");
        foreach (Ostos ostos in  ostokset)
         {
                Console.WriteLine(ostos.ToString());
            }
    }
}
}
