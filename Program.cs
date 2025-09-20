using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSeriesByRecursion
{
    internal class Program
    {
        static int n = 1;
        static void Main(string[] args)
        {
            PrintSeries(256);
            Console.ReadLine();
        }
        public static void PrintSeries(int limit)
        {
            if (n < limit)
            {
                n = n * 2;
                Console.Write(n + " \t ");
                PrintSeries(limit);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
