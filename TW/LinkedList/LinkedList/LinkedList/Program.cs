using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLIst myLinkedLIst = new LinkedLIst();
            myLinkedLIst.Add(10);
            myLinkedLIst.Add("dasfsd");
            Console.WriteLine(myLinkedLIst.Get(2));
        }
    }
}
