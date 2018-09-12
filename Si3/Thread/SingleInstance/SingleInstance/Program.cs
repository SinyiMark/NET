using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SingleInstance
{
    class Program
    {
        static string name = "RUNMEONLYONCE";
        static void Main(string[] args)
        {
            Mutex mx = null;
            while (true)
            {
                try
                {
                    mx = Mutex.OpenExisting(name);
                    mx.Close();
                    Console.WriteLine("asd");
                    Environment.Exit(0);
                }
                catch (WaitHandleCannotBeOpenedException)
                {
                    mx = new Mutex(true, name);
                }
            }
        }
    }
}
