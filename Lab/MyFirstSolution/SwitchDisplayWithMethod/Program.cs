using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDisplayWithMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("pls input a num:");
            string input = Console.ReadLine();
            //int value = int.Parse(input);

            string result = Getresult(int.Parse(input));
            //string result = Getresult(value);
            Console.WriteLine(result);
            Console.ReadLine();
        }
   
            
    private static string Getresult(int i)
        {
            switch(i)
            {
                case 1:
                    return "The num is 1";
                case 2:
                    return "The num is 2";
                default:
                    return "The num isn't 1 or 2";
            }
        }
    }
}
