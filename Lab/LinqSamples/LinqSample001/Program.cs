using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MyData> list = CreateList();

            //Query Expression      // I Enumerable  I = Int  Enumerable = 可以被列舉的(可以被foreach的)
            IEnumerable<MyData> people =   //IEnumerable...from...where...select... 很像 foreach
                // 呼叫MyData存在data裡 並從data找到名字=Bill的List存在people中 
                from data in list
                where data.Name == "Bill"
                select data;

            //result.show
            foreach (MyData person in people)
                Console.WriteLine($"{person.Name} 是 {person.Age} 歲");

            Console.ReadLine();            
        }

        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData { Name = "Bill", Age = 47 },
                new MyData { Name = "John", Age = 37 },
                new MyData { Name = "Tom", Age = 48 },
                new MyData { Name = "David", Age = 36 },
                new MyData { Name = "Bill", Age = 35 },
            };            
        }
    }
}
