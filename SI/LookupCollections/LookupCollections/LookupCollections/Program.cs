using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookupCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var ld = new ListDictionary();
            ld.Add("Estados Unidos", "United States");
            ld.Add("España", "Spain");
            ld.Add("Canadá", "Canada");
            foreach (DictionaryEntry k in ld)
            {
                Console.WriteLine($"{k.Key}: {k.Value}");
            }
        }
    }
}
