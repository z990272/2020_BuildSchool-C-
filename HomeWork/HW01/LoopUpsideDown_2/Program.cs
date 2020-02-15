using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數數字:");
            string input = Console.ReadLine();
            int value = int.Parse(input);

            for (int i = value; i >= 1; i--)
            {
                for (int j = 0; j <= value-i; j++)
                    Console.Write(i);

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
