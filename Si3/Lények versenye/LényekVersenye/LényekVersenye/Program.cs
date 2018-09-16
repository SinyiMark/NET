using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LényekVersenye
{
    class Program
    {
        static List<Lény> Lények = new List<Lény>();
        public enum Napszakok {Napos,Felhős,Esős}

        public static void Verseny(int körök)
        {
            Random rnd = new Random();
            for (int i = 0; i < körök; i++)
            {
                Napszakok aktuálisNapszakok = (Napszakok)rnd.Next(0,2);
                foreach (var lény in Lények)
                {
                    lény.Lépés(aktuálisNapszakok);
                }
            }
            foreach (var lény in Lények)
            {
                Console.WriteLine(lény.ToString());
            }
        }

        static void Main(string[] args)
        {
            Lények.Add(new HomokJáró("HomokJáró"));
            Lények.Add(new Szivacs("Szivacs"));
            Verseny(5);
            Verseny(10);
        }
    }
}
