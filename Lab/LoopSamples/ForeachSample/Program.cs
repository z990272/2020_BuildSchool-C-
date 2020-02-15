using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 1, 2, 3, 4, 5, 6 };
            int [,] array = { { 1, 3, 3 },{ 4, 7, 6 } };
            //int [] array =new int[] {1,2,3,4,5,6};
            foreach (int i in array)
                Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
