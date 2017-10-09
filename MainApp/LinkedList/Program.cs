using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var presidents = new LinkedList<string>();
            presidents.AddLast("JFK");
            presidents.AddLast("Lyndon B Johnson");
            presidents.AddLast("Richard Nixon");
            presidents.AddLast("Jimmy Carter");

            presidents.AddLast("some fucking president after Carter");

            var fingPres = presidents.Find("some fucking president after Carter");
            presidents.Remove(fingPres);

            presidents.AddFirst("new first president");

            foreach (var p in presidents) 
            {
                Console.WriteLine(p);
            }

            
            //presidents.AddFirst()
        }
    }
}
