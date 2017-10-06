using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch fillingTimeWatch = new Stopwatch();
            Stopwatch sortTimeWatch = new Stopwatch();

            fillingTimeWatch.Start();



            

            int myN = 200000000;
            byte[] ma = new byte[myN];
            
            var r = new Random();
            r.NextBytes(ma);
            /*
            for (int i = 0; i < myN; i++)
            {
                ma[i] = r.N;
            }
            */

            fillingTimeWatch.Stop();

            sortTimeWatch.Start();
            Array.Sort<byte>(ma);
            sortTimeWatch.Stop();

            ShowElapsedTime(fillingTimeWatch, "filling the array");
            ShowElapsedTime(sortTimeWatch, "sorting the array");

        }

        static void ShowElapsedTime(Stopwatch sw, string desc)
        {
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = sw.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}h:{1:00}m:{2:00}s" +
                "",
                ts.Hours, ts.Minutes, ts.Seconds);

            Console.WriteLine($"Elapsed time for {desc}: " + elapsedTime);
        }
    }
}
