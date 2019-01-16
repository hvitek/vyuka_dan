using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzole
{
    public static class MathOpr
    {
        public static double DelkaPrepony(int a, int b)
        {
            //int c2 = MathOprBase.Vynasob(a, a) + MathOprBase.Vynasob(b, b);
            int c2 = MathOprBase.Secti(MathOprBase.Vynasob(a, a), MathOprBase.Vynasob(b, b));
            double vysledek = Math.Sqrt(c2);
            return vysledek;
        }
    }

}
