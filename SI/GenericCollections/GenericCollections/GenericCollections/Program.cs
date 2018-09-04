using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<int, string>();
            d.Add(1, "asd");
            d.Add(2, "wasd");
            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
