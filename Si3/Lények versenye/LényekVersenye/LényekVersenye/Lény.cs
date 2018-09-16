using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LényekVersenye
{
    public abstract class Lény
    {
        public Lény(string név)
        {
            Név = név;
        }

        private int víz;

        public int Víz
        {
            get { return víz; }
            set {
                víz = value;
                if (víz > MaxVíz)
                {
                    víz = MaxVíz;
                }
            }
        }

        public int MegtettTávolság { get; set; } = 0;
        public string Név { get; set; }
        public int MaxVíz { get; set; }
        public bool Él { get; set; } = true;
        public int NaposVízVáltozás { get; set; }
        public int FelhősVízVáltozás { get; set; }
        public int EsősVízVáltozás { get; set; }
        public int NaposHaladás { get; set; }
        public int FelhősHaladás { get; set; }
        public int EsősHaladás { get; set; }

        public void Szomjuság()
        {
            if (Víz < 1)
            {
                if (Él)
                {
                    Console.WriteLine($"{Név} meghalt");
                }
                Él = false;
            }
        }

        public void Lépés(Enum Időjárás)
        {
            if (!Él)
            {
                return;
            }
            if (Időjárás.ToString() ==  "Napos")
            {
                Víz = Víz + NaposVízVáltozás;
            }else if(Időjárás.ToString() == "Felhős")
            {
                Víz = Víz + FelhősVízVáltozás;
            }
            else if(Időjárás.ToString() == "Esős")
            {
                Víz = Víz + EsősVízVáltozás;
            }
            else
            {
                Console.WriteLine("Időjárás hibás értéket kapot!");
            }
            Szomjuság();
            if (Él)
            {
                if (Időjárás.ToString() == "Napos")
                {
                    MegtettTávolság = MegtettTávolság + NaposHaladás;
                }
                else if (Időjárás.ToString() == "Felhős")
                {
                    MegtettTávolság = MegtettTávolság + FelhősHaladás;
                }
                else if (Időjárás.ToString() == "Esős")
                {
                    MegtettTávolság = MegtettTávolság + EsősHaladás;
                }
            }
        }
        public override string ToString()
        {
            return $"{Név}  {MegtettTávolság} {Él}";
        }
    }
}
