using AlgoritmsAndDataStructures.ES;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = Time_complexity.ReadInts("1Kints.txt").ToArray();
            var wathc = new Stopwatch();
            wathc.Start();

            var triplets = ThreeSum.Count(ints);
            wathc.Stop();

            Console.WriteLine($"The number of \"zero-sum\" triplets :{triplets}");
            Console.WriteLine($"The taken {wathc.Elapsed:g}");
        }
    }
}
