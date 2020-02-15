﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();

            var min = list.Where((x) => x.Name == "Bill").Min((x) => x.Age);
            Console.WriteLine($"所有 Bill 中年齡最小的是: {min}");

            var total = list.Where((x) => x.Name == "Bill").Sum((x) => x.Age);
            Console.WriteLine($"所有 Bill 的年齡總和是: {total}");

            var avg = list.Where((x) => x.Name == "Bill").Average((x) => x.Age);
            Console.WriteLine($"所有 Bill 的年齡平均是: {avg}");

            Console.ReadLine();
        }

        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData() { Name = "Bill", Age = 47 },
                new MyData() { Name = "John", Age = 37 },
                new MyData() { Name = "Tom", Age = 48 },
                new MyData() { Name = "David", Age = 36 },
                new MyData() { Name = "Bill", Age = 35 },
            };
        }
    }
}
