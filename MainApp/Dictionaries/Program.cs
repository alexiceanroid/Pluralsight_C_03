using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>()
            
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                { "MT", new PrimeMinister("Margaret Thatcher", 1979) },
                { "TB", new PrimeMinister("Tony Blair", 1997) }
            };

            var pms = new ReadOnlyDictionary<string, PrimeMinister>(primeMinisters);
            

            foreach (var readonly_pres in pms)
            {
                //readonly_pres.Value += "t";
                Console.WriteLine(readonly_pres.Value);
            }
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
}
