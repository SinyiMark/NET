using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPoolDemo
{
    class Program
    {
        public static void ShowMyText(object state)
        {
            string store = state.ToString();
            Console.WriteLine($"{store}{Thread.CurrentThread.ManagedThreadId}");
        }
        static void Main(string[] args)
        {
            var th = new Thread(new WaitCallback(ShowMyText()));
        }
    }
}
