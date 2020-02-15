using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinpSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();

            int total = list.Sum((x) => x.Age);
            Console.WriteLine($"年齡的總和為: {total}");

            var minAge = list.Min((x) => x.Age);
            Console.WriteLine($"最小的年齡為: {minAge}");

            var maxAge = list.Min((x) => x.Age);
            Console.WriteLine($"最大的年齡為: {maxAge}");

            int count = list.Count();
            Console.WriteLine($"list 總個數為: {count}");

            int countofBill = list.Count((x) => x.Name == "Bill");
            Console.WriteLine($"list 中的 Bill 總數量為: {countofBill}");

            var avg = list.Average((x) => x.Age);
            Console.WriteLine($"年齡的平均值為: {avg}");

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
