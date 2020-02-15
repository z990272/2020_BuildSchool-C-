using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 1911;
            Console.Write("請輸入一個中華民國年份:");
            string input = Console.ReadLine();
            int value = int.Parse(input) + temp;

            if (value % 4 == 0 && value % 100 != 0)
                Console.WriteLine($"民國{input}年是閏年");
            else if(value % 400 == 0)
                Console.WriteLine($"民國{input}年是閏年");
            else
                Console.WriteLine($"民國{input}年不是閏年");

            Console.ReadLine();
        }
    }
}
