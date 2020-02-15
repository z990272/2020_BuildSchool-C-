using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 5, i2 = 3;
            double d = 9.8;
            string s1 = "The", s2 = "End";

            Console.WriteLine(i1 + i2);  // 5 + 3 = 8
            Console.WriteLine(i1 + d);   // 5 + 9.8 = 14.8
            Console.WriteLine(s1 + s2);  // The + End = TheEnd
            Console.WriteLine(s1 + i1);  // The + 5 = The5
            Console.WriteLine(d + s2);   // 9.8 + End = 9.8End
            Console.ReadLine();
        }
    }
}
