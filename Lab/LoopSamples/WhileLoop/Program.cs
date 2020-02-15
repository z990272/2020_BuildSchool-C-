using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while (i < 11)
            {
                sum += i;
                i++;
            }
            Console.WriteLine($"1~10的總和為{sum}");
            Console.ReadLine();
        }
    }
}
