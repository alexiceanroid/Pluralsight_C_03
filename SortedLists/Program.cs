using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new SortedList<string, PrimeMinister>(StringComparer.InvariantCultureIgnoreCase)
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

    struct PrimeMinister
    {
        public string Name { get; private set; }
        public int YearElected { get; private set; }

        public PrimeMinister(string name, int yearElected)
        {
            this.Name = name;
            this.YearElected = yearElected;
        }

        public override string ToString()
        {
            return $"{this.Name}, elected in {this.YearElected}";
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
