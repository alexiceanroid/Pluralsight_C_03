using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeMinisterLibrary;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new SortedDictionary<string, PrimeMinister>(StringComparer.InvariantCultureIgnoreCase)
                //(new CustomKeyComparer())

            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                { "MT", new PrimeMinister("Margaret Thatcher", 1979) },
                { "TB", new PrimeMinister("Tony Blair", 1997) }
            };


            Console.WriteLine($"tony is {primeMinisters["tb"]}");
            /*
            foreach (var pm in primeMinisters)
            {
                
                Console.WriteLine(pm);
            }
            */
        }
    }

    

    class CustomKeyComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.ToUpper().CompareTo(y.ToUpper());
        }
    }
}
