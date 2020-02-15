using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一串連續數字(以逗號隔開):");
            string input = Console.ReadLine();
            string[] value = input.Split(',');
            int[] newvalue = new int[value.Length];

            for (int i = 0; i < value.Length; i++)
            {
                int temp = int.Parse(value[i]);
                newvalue[i] += temp;
            }
            Array.Reverse(newvalue);

            for (int i = 0; i < value.Length; i++)
                if (i < value.Length - 1)
                    Console.Write(newvalue[i] + ",");
                else
                    Console.Write(newvalue[i]);

            Console.ReadLine();
        }
    }
}
