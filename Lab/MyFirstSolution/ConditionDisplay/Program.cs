using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            int condition = 10;
            Console.Write("請輸入一個數字:");
            string input = Console.ReadLine();
            int value = int.Parse(input);

            if(value > condition)
                Console.WriteLine("輸入的值大於" + condition);
            else if(value < condition)
                Console.WriteLine("輸入的值小於 {0}",condition);
            else 
                //用 $ 在帶很多變數時會比較方便 
                // $ = String.Format()
                Console.WriteLine($"輸入的值等於{condition}");
            
            Console.ReadLine();
        }
    }
}
