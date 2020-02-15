using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._2
{
    class Program
    {
        static void Main(string[] args)
        {                       
            Console.Write("請輸入一串連續數字(以逗號隔開):");
            string input = Console.ReadLine();
            string[] value = input.Split(',');
            int[] newvalue = new int [value.Length];
            
            for (int i = 0; i < value.Length; i++)
            {
                int temp = int.Parse(value[i]);
                newvalue[i] += temp;
            }
            Array.Sort(newvalue); //將陣列由小到大排列

            int a = 0, b = 0;           
            foreach (int i in newvalue)
            {
                if (i % 2 != 0)
                    a += 1;
                else
                    b += 1;               
            }
            int[] s = new int[a];
            int[] e = new int[b];

            int c = 0, d = 0;
            foreach (int i in newvalue)
            {
                if (i % 2 != 0)
                {
                    s[c] += i;
                    c += 1;
                }                   
                else
                {
                    e[d] += i;
                    d += 1;
                }                    
            }

            Console.WriteLine("奇數的有:");
            for (int i = 0; i < s.Length; i++)
                if(i<s.Length-1)
                    Console.Write(s[i]+",");
                else
                    Console.Write(s[i]);

            Console.WriteLine();
            Console.WriteLine("偶數的有:");
            for (int i = 0; i < e.Length; i++)
                if (i < e.Length - 1)
                    Console.Write(e[i] + ",");
                else
                    Console.Write(e[i]);

            Console.ReadLine();
        }
    }
}
