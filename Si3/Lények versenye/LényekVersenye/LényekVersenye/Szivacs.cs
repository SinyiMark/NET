using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LényekVersenye
{
    class Szivacs : Lény
    {
        public Szivacs(string név) : base(név)
        {
            MaxVíz = 20;
            Víz = 20;
            NaposHaladás = 0;
            FelhősHaladás = 1;
            EsősHaladás = 3;
            NaposVízVáltozás = -4;
            FelhősVízVáltozás = -1;
            EsősVízVáltozás = 6;
        }

    }
}
