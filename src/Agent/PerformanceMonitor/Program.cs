using System;
using System.Diagnostics;

namespace PerformanceMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            var input = Console.ReadLine();
            while (input != "exit")
            {
                Console.WriteLine("Counter is {0}", counter.NextValue());
                input = Console.ReadLine();
            }

        }
    }
}
