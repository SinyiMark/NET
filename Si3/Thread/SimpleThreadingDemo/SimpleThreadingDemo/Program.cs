using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        public static void Counting()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine($"Id: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            }
        }
        static void Main(string[] args)
        {
            Thread th = new Thread(new ThreadStart(Counting));
            Thread th2 = new Thread(new ThreadStart(Counting));
            th.Start();
            th2.Start();
            th.Join(10);
        }
    }
}
