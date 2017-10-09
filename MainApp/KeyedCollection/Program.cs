using PrimeMinisterLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyedCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<int, PrimeMinister>()

            {
                {1976, new PrimeMinister("James Callaghan", 1976) },
                {1979, new PrimeMinister("Margaret Thatcher", 1979) },
                {1997, new PrimeMinister("Tony Blair", 1997) }
            };


            Console.WriteLine($"tony is {primeMinisters[1997]}");
            /*
            foreach (var pm in primeMinisters)
            {
                
                Console.WriteLine(pm);
            }
            */
        }
    }
}
