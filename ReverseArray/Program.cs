using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //Array.Reverse(daysOfWeek);
            var reversed = daysOfWeek.Reverse<string>().ToArray();

            foreach(string day in reversed)
            {
                Console.WriteLine(day);
            }
        }
    }
}
