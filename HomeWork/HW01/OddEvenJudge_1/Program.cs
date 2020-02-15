using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數數字:");
            string input = Console.ReadLine();
            int value = int.Parse(input);

            if (value % 2 == 1)
                Console.WriteLine($"{value}是一個奇數");
            else
                Console.WriteLine($"{value}是一個偶數");

            Console.ReadLine();
        }
    }
}
