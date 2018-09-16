using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LényekVersenye
{
    public class HomokJáró : Lény
    {
        public HomokJáró(string név) : base(név)
        {
            MaxVíz = 8;
            Víz = 8;
            NaposHaladás = 3;
            FelhősHaladás = 1;
            EsősHaladás = 0;
            NaposVízVáltozás = -1;
            FelhősVízVáltozás = 0;
            EsősVízVáltozás = 0;
        }


    }
}
