using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個數字:");
            string input = Console.ReadLine();
            int value = int.Parse(input);

            switch(value)
                //可以先打default 紅蚯蚓就不會一直出現
            {
                case 1:
                    Console.WriteLine("輸入的值為 1");
                    break;

                case 2:
                    Console.WriteLine("輸入的值為 2");
                    break;

                default:
                    Console.WriteLine("輸入的值不為 1 或 2");
                    break;
            }
            Console.ReadLine();
        }
    } 
}
