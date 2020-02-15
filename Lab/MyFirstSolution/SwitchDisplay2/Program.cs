using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDisplay2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個數字:");
            string input = Console.ReadLine();
            int value = int.Parse(input);
            //因為ReadLine讀進來的input是string 所以用int.Parse轉換型態

            switch(value)
            {
                case 1:case 2:
                    Console.WriteLine("輸入的數字為 1 或 2");
                    break;

                default:
                    Console.WriteLine("輸入的數字不為 1 或 2");
                    break;
            }
            Console.ReadLine();
        }
    }
}
