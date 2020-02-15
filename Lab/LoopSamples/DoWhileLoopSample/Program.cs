using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            do
            {
                sum += i;
                i++;
            } while (i < 11);

            Console.WriteLine($"1~10的加總為{sum}");
            Console.ReadLine();
        }
    }
}
