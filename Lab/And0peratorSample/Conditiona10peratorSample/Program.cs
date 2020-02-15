using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditiona10peratorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 10, x2 = 10;
            string y1 = "abc", y2 = "abc";

            if (x1 == x2 && y1 == y2)
                Console.WriteLine("都正確");
            else
                Console.WriteLine("至少有一不正確");       
            if (x1 == x2 || y1 == y2)
                Console.WriteLine("至少有一正確");           
            else
            Console.WriteLine("都不正確");
            
            Console.ReadLine();
        }
    }
}
