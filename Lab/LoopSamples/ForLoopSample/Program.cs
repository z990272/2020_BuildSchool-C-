using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
                sum += i;

            Console.WriteLine($"1~10的加總為{sum}");
            Console.ReadLine();
        }
    }
}
